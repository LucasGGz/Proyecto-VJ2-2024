using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraInput : MonoBehaviour
{
    private float hor;
    private float ver;

    public float Hor { get => hor; set => hor = value; }
    public float Ver { get => ver; set => ver = value; }

    //inputs para el mouse
    void Update()
    {
        Ver = Input.GetAxis("Mouse Y");
        Hor = Input.GetAxis("Mouse X");
    }
}
