using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFunctColl : MonoBehaviour
{
    public float maxDistance;
    CamaraFunctOrbit camOrbit;
    CalculoPlanePlayer planePlayer;
    CamaraFunctFollow functFollow;
    public float Distance { get => distance; set => distance = value; }

    private float distance;
    void Start()
    {
        functFollow = GetComponent<CamaraFunctFollow>();
        camOrbit = GetComponent<CamaraFunctOrbit>();
        planePlayer = GetComponent<CalculoPlanePlayer>();
    }

    void LateUpdate()
    {
        FuncionamientoCollideCamara();
    }

    //Funcionamiento de la colision de los puntos calculados para la camara
    private void FuncionamientoCollideCamara()
    {
        RaycastHit hit;
        distance = maxDistance;
        //Se va a obtener los puntos del metodo del plano calculado
        Vector3[] points = planePlayer.getCameraCollionPoint(camOrbit.CalculoOrbitacionCam()); //Le pasamos el calculo de orbit a esos puntos

        //se pasa por cada uno de los puntos y se hace un raycast 
        foreach (Vector3 point in points)
        {
            //Los puntos del raycast van desde cada punto del plano calculado hasta la direccion de la camara (pos de la cam )
            if (Physics.Raycast(point, camOrbit.CalculoOrbitacionCam(), out hit, maxDistance))
            {
                distance = Mathf.Min((hit.point - functFollow.Follow.position).magnitude, distance); // Si colisiona algun punto se reubica la cam
            }
        }

    }
}
