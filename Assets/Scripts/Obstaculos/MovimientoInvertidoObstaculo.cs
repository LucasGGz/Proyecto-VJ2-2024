using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MovimientoInvertidoObstaculo : NetworkBehaviour
{
    private float amplitud = 3f; 
    private float velocidad = 1f; 

    private float tiempoInicio;

    private void Start()
    {
        // Guarda el tiempo de inicio 
        tiempoInicio = Time.time;
    }

    [ServerRpc]
    private void MoverObstaculoServerRpc(Vector3 position)
    {
        // Calcula el desplazamiento lateral 
        float desplazamientoLateral = amplitud * Mathf.Sin((Time.time - tiempoInicio) * velocidad);
        Vector3 direccionLateral = new Vector3(0, 0, -1) * desplazamientoLateral; 

        transform.position += direccionLateral * Time.deltaTime;
    }

    private void Update()
    {
        if (IsServer) // Verifica si el script se está ejecutando en el servidor
        {
            MoverObstaculoServerRpc(transform.position);
        }
    }
}
