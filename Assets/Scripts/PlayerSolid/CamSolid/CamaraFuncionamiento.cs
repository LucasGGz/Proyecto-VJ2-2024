using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFuncionamiento : MonoBehaviour
{
    [SerializeField] private Transform follow;
    public float maxDistance;
    CamaraMov camMov;
    CalculoPlanePlayer player;
    public Transform Follow { get => follow; set => follow = value; }

    void Start()
    {
        camMov = GetComponent<CamaraMov>();
        player = GetComponent<CalculoPlanePlayer>();
    }

    void LateUpdate()
    {
        FuncionamientoCamara();
    }

    //Funcionamiento de la camara
    private void FuncionamientoCamara()
    {
        //para que orbite al jugador
        Vector3 direction = new Vector3(
            Mathf.Cos(camMov.Angle.x) * Mathf.Cos(camMov.Angle.y),
            -Mathf.Sin(camMov.Angle.y),
            -Mathf.Sin(camMov.Angle.x) * Mathf.Cos(camMov.Angle.y));
        //

        RaycastHit hit;
        float distance = maxDistance;
        Vector3[] points = player.getCameraCollionPoint(direction); //se va a obtener los puntos del metodo del plano calculado

        //se pasa por cad uno de los puntos y se hace un raycast 
        foreach (Vector3 point in points)
        {
            //los puntos del raycast van desde cada punto del plano calculado hasta la direccion de la camara (pos de la cam )
            if (Physics.Raycast(point, direction, out hit, maxDistance))
            {
                distance = Mathf.Min((hit.point - follow.position).magnitude, distance); // si colisiona algun punto se reubica la cam
            }
        }

        transform.position = follow.position + direction * distance; //para que la cam siga al jugador y pueda rodear al pj
        transform.rotation = Quaternion.LookRotation(follow.position - transform.position); //para que la cam pueda rotar al jguador 
    }
}
