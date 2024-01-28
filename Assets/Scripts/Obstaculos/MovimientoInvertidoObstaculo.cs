using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class MovimientoInvertidoObstaculo : NetworkBehaviour
{
    public float velocidad = 5f;

    [ServerRpc]
    private void MoverObstaculoInvertidoServerRpc(Vector3 position, Vector3 direction)
    {
        transform.Translate(-direction * velocidad * Time.deltaTime);

        if (transform.position.z > 10f || transform.position.z < -10f)
        {
            velocidad *= -1;
        }
    }

    private void Update()
    {
        if (IsServer)
        {
            MoverObstaculoInvertidoServerRpc(transform.position, transform.forward);
        }
    }
}
