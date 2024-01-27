using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class GeneradorObstaculos : NetworkBehaviour
{
    [SerializeField] public GameObject obstaculoPrefab; // Prefab del obstáculo
    public float velocidadMovimiento = 5f; // Velocidad de movimiento de los obstáculos

    [ServerRpc]
    public void InstantiarObstaculoServerRpc()
    {
        GameObject nuevoObstaculo = Instantiate(obstaculoPrefab);
        nuevoObstaculo.GetComponent<NetworkObject>().Spawn(true);
    }
}
