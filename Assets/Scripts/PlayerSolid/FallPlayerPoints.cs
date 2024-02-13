using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallPlayerPoints : MonoBehaviour
{
    // Variables para los puntos de posición a los que el jugador será teletransportado al caer
    private Vector3 point, point2, point3, pointV2, point4, point5, point6, point7, point8, point9;

    public Vector3 Point { get => point; set => point = value; }
    public Vector3 Point2 { get => point2; set => point2 = value; }
    public Vector3 Point3 { get => point3; set => point3 = value; }
    public Vector3 PointV2 { get => pointV2; set => pointV2 = value; }
    public Vector3 Point4 { get => point4; set => point4 = value; }
    public Vector3 Point5 { get => point5; set => point5 = value; }
    public Vector3 Point6 { get => point6; set => point6 = value; }
    public Vector3 Point7 { get => point7; set => point7 = value; }
    public Vector3 Point8 { get => point8; set => point8 = value; }
    public Vector3 Point9 { get => point9; set => point9 = value; }

    void Start()
    {
        // Inicialización de los puntos de posición
        Point = new Vector3(0, 2f, 0);
        Point2 = new Vector3(0, 3f, 90f);
        PointV2 = new Vector3(62, 3f, 90f);
        Point3 = new Vector3(4, 3f, 180f);
        Point4 = new Vector3(91f, 5f, 184f);
        Point5 = new Vector3(220, 17, 184f);
        Point6 = new Vector3(4, 11, 200f);
        Point7 = new Vector3(4, 11, 256f);
        Point8 = new Vector3(4, 11, 340);
        Point9 = new Vector3(4, 11, 412);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
