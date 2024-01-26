using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class GeneradorObstaculos : NetworkBehaviour
{
    [SerializeField] public GameObject obstaculoPrefab; // Prefab del obst�culo
    public float velocidadMovimiento = 5f; // Velocidad de movimiento de los obst�culos

    private bool generadorActivado = false;

    private void OnTriggerEnter(Collider other)
    {
        if (IsServer && other.CompareTag("Player") && !generadorActivado)
        {
            InstantiarObstaculoServerRpc();
            generadorActivado = true; // Marcar el generador como activado
        }
    }

    [ServerRpc]
    public void InstantiarObstaculoServerRpc()
    {
        GameObject nuevoObstaculo = Instantiate(obstaculoPrefab, Vector3.zero, Quaternion.identity);
        nuevoObstaculo.GetComponent<NetworkObject>().Spawn(true);
        MovimientoObstaculo movimientoObstaculo = nuevoObstaculo.AddComponent<MovimientoObstaculo>();
        movimientoObstaculo.velocidad = velocidadMovimiento;
    }
}
