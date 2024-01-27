using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MovimientoObstaculo : NetworkBehaviour
{
    public float velocidad = 5f;

    [ServerRpc]
    private void MoverObstaculoServerRpc(Vector3 position, Vector3 direction)
    {
        // Mueve el obstáculo hacia adelante y hacia atrás
        transform.Translate(direction * velocidad * Time.deltaTime);

        // Si llega al límite, invierte la dirección
        if (transform.position.z > 10f || transform.position.z < -10f)
        {
            velocidad *= -1;
        }
    }

    private void Update()
    {
        if (IsServer)
        {
            MoverObstaculoServerRpc(transform.position, transform.forward);
        }
    }
}