using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculoPlaneCam : MonoBehaviour
{
    CalculoPlanePlayer player;
    // Use this for initialization
    void Start()
    {
        player = GetComponent<CalculoPlanePlayer>();
        CalculateNearPlane();
    }

    
    //calcular el plano cercano a la camara que parece un rectangulo
    private void CalculateNearPlane()
    {
        float height = Mathf.Tan(player.Camera.fieldOfView * Mathf.Deg2Rad / 2) * player.Camera.nearClipPlane; //se calcula en funcion de la tan para obtener el alto
        float width = height * player.Camera.aspect; //se calcula el ancho

        player.NearPlaneSize = new Vector2(width, height); //se lo guardo en una variable
    }
}
