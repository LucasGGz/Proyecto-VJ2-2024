using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraInput : MonoBehaviour
{
    private float hor;
    private float ver;

    public float Hor { get => hor; set => hor = value; }
    public float Ver { get => ver; set => ver = value; }

    //Inputs para el mouse
    void Update()
    {
        //Se le asignan los Inputs
        Ver = Input.GetAxis("Mouse Y");
        Hor = Input.GetAxis("Mouse X");
    }
}
