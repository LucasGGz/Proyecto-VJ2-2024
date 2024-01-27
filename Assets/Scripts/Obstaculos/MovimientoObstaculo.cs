using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MovimientoObstaculo : NetworkBehaviour
{
    public float velocidad = 5f;

    [ServerRpc]
    private void MoverObstaculoServerRpc(Vector3 position, Vector3 direction)
    {
        // Mueve el obst�culo hacia adelante y hacia atr�s
        transform.Translate(direction * velocidad * Time.deltaTime);

        // Si llega al l�mite, invierte la direcci�n
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