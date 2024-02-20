using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class CamaraFunctOrbit : MonoBehaviour
{
    CamaraMov camMov;
    void Start()
    {
        camMov = GetComponent<CamaraMov>();
    }

    //Calculo para que pueda orbitar al jugador
    public Vector3 CalculoOrbitacionCam()
    {
        //Para que orbite al jugador
        Vector3 direction = new Vector3(
        Mathf.Cos(camMov.Angle.x) * Mathf.Cos(camMov.Angle.y),
            -Mathf.Sin(camMov.Angle.y),
            -Mathf.Sin(camMov.Angle.x) * Mathf.Cos(camMov.Angle.y));

        return direction; //Retorna la direccion
    }
}
