using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculoPlanePlayer : MonoBehaviour
{
    CamaraFunctFollow functFollow;
    private new Camera camera;
    private Vector2 nearPlaneSize;

    public Vector2 NearPlaneSize { get => nearPlaneSize; set => nearPlaneSize = value; }
    public Camera Camera { get => camera; set => camera = value; }

    void Start()
    {
        functFollow = GetComponent<CamaraFunctFollow>();
        Camera = GetComponent<Camera>();
    }

    //Se calcula el plano que va a estar cerca del jugador para los raycaces 
    public Vector3[] getCameraCollionPoint(Vector3 direction)
    {
        Vector3 position = functFollow.Follow.position; //Se lo situa en el player target
                                                    //Centro del plano
        Vector3 center = position + direction * (Camera.nearClipPlane + 0.1f); //Y se lo aleja un poco al plano  

        Vector3 right = transform.right * NearPlaneSize.x; //Se calcula para ir a la derecha
        Vector3 up = transform.up * NearPlaneSize.y;// Y arriba

        //Puntos que van a partir desde el centro hacia las 4 esquinas del plano 
        return new Vector3[]
        {
            center - right + up,
            center + right + up,
            center - right - up,
            center + right - up
        };
    }
}
