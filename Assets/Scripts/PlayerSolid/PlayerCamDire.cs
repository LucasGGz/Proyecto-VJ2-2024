using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamDire : MonoBehaviour
{
    private Vector3 camForward;
    private Vector3 camRight;
    public GameObject Camara3era;

    public Vector3 CamRight { get => camRight; set => camRight = value; }
    public Vector3 CamForward { get => camForward; set => camForward = value; }

    void Update()
    {
        camDirection();
    }

    //Metodo para calcular la direccion de la camara
    public void camDirection()
    {
        //Direccion hacia adelnte y derecha de la camara
        CamForward = Camara3era.transform.forward;
        CamRight = Camara3era.transform.right;
        // Ajustar las componentes Y a cero para obtener una dirección horizontal
        camForward.y = 0;
        camRight.y = 0;
        // Normalizar las direcciones
        CamForward = CamForward.normalized;
        CamRight = CamRight.normalized;
    }
}
