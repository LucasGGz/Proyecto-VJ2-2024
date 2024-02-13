using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFuncionamiento : MonoBehaviour
{
    public float maxDistance;
    CamaraFunctOrbit camOrbit;
    CalculoPlanePlayer planePlayer;
    CamaraFunctFollow functFollow;
    public float Distance { get => distance; set => distance = value; }

    private float distance;
    void Start()
    {
        functFollow= GetComponent<CamaraFunctFollow>();
        camOrbit = GetComponent<CamaraFunctOrbit>();
        planePlayer = GetComponent<CalculoPlanePlayer>();
    }

    void LateUpdate()
    {
     //   FuncionamientoCamara();
    }

    //Funcionamiento de la camara
  /*  private void FuncionamientoCamara()
    {
        RaycastHit hit;
        distance = maxDistance;
        //se va a obtener los puntos del metodo del plano calculado
        Vector3[] points = planePlayer.getCameraCollionPoint(camOrbit.CalculoOrbitajeCam()); //le pasamos el calculo de orbit a esos puntos

        //se pasa por cad uno de los puntos y se hace un raycast 
        foreach (Vector3 point in points)
        {
            //los puntos del raycast van desde cada punto del plano calculado hasta la direccion de la camara (pos de la cam )
            if (Physics.Raycast(point, camOrbit.CalculoOrbitajeCam(), out hit, maxDistance))
            {
                distance = Mathf.Min((hit.point - functFollow.Follow.position).magnitude, distance); // si colisiona algun punto se reubica la cam
            }
        }

    }*/

 
}
