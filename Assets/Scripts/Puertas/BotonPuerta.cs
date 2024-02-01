using UnityEngine;
using Unity.Netcode;

// Clase principal para el bot�n de la puerta
public class BotonPuerta : NetworkBehaviour
{
    [SerializeField] private PuertaNetwork puertaNetwork;

    private void OnTriggerEnter(Collider other)
    {
        if (IsServer)
        {
            puertaNetwork.ActivarPuertaServerRpc();
            Debug.Log("DetectoCollision");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (IsServer)
        {
            puertaNetwork.DesactivarPuertaServerRpc();
        }
    }
}