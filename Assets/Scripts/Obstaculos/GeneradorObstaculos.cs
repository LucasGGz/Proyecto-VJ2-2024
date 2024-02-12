using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class GeneradorObstaculos : NetworkBehaviour
{
    [SerializeField] public GameObject obstaculoPrefab;
    [SerializeField] public GameObject obstaculoInvertidoPrefab;

    public float velocidadMovimiento = 5f;

    [ServerRpc]
    public void InstantiarObstaculoServerRpc(bool invertido)
    {
        GameObject nuevoObstaculo = Instantiate(invertido ? obstaculoInvertidoPrefab : obstaculoPrefab);

        // Lógica para Spawn en la red
        nuevoObstaculo.GetComponent<NetworkObject>().Spawn(true);
    }

    public void ActivarGenerador(bool invertido)
    {
        InstantiarObstaculoServerRpc(invertido); // Llama al RPC del servidor para instanciar un obstáculo
    }
}