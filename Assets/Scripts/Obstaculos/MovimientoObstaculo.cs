using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MovimientoObstaculo : NetworkBehaviour
{
    public float velocidad = 5f;

   [ServerRpc]
    private void MoverObstaculoServerRpc(Vector3 position, Vector3 direction)
    {
        transform.Translate(direction * velocidad * Time.deltaTime);

        if (transform.position.z > 113f || transform.position.z < 108f)
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