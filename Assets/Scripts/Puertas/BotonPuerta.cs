using UnityEngine;
using Unity.Netcode;

// Clase principal para el botón de la puerta
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