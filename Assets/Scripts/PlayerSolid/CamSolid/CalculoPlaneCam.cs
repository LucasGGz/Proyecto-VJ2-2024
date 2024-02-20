using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculoPlaneCam : MonoBehaviour
{
    CalculoPlanePlayer planePlayer;
    // Use this for initialization
    void Start()
    {
        planePlayer = GetComponent<CalculoPlanePlayer>();
        CalculateNearPlane();
    }

    
    //Calcular el plano cercano a la camara que parece un rectangulo
    private void CalculateNearPlane()
    {
        float height = Mathf.Tan(planePlayer.Camera.fieldOfView * Mathf.Deg2Rad / 2) * planePlayer.Camera.nearClipPlane; //Se calcula en funcion de la tan para obtener el alto
        float width = height * planePlayer.Camera.aspect; //Se calcula el ancho

        planePlayer.NearPlaneSize = new Vector2(width, height); //Se lo guardo en una variable
    }
}
