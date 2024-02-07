using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MovimientoInvertidoObstaculo : NetworkBehaviour
{
    private float amplitud = 3f; // La amplitud del movimiento lateral
    private float velocidad = 1f; // La velocidad del movimiento lateral

    private float tiempoInicio;

    private void Start()
    {
        // Guardar el tiempo de inicio para asegurar un movimiento suave
        tiempoInicio = Time.time;
    }

    [ServerRpc]
    private void MoverObstaculoServerRpc(Vector3 position)
    {
        // Calcular la posición lateral utilizando una función sinusoidal
        float desplazamientoLateral = amplitud * Mathf.Sin((Time.time - tiempoInicio) * velocidad);
        Vector3 direccionLateral = new Vector3(0, 0, -1) * desplazamientoLateral; // Cambiado de 1 a -1

        // Mover el obstáculo
        transform.position += direccionLateral * Time.deltaTime;
    }

    private void Update()
    {
        if (IsServer)
        {
            MoverObstaculoServerRpc(transform.position);
        }
    }
}
