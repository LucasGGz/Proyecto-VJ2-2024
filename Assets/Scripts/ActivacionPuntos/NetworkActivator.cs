using UnityEngine;
using Unity.Netcode;

// Maneja la comunicación de red.

public class NetworkActivator : NetworkBehaviour
{
    [SerializeField] private ActivadorObjeto activadorObjeto;

    // Método RPC ejecutado en el servidor para activar el objeto
    [ServerRpc]
    private void InstantiaServerRpc()
    {
        activadorObjeto.Activar();
        activadorObjeto.GetComponent<NetworkObject>().Spawn();
    }

    // Método RPC ejecutado en el servidor para desactivar el objeto
    [ServerRpc]
    private void DesactivarServerRpc()
    {
        activadorObjeto.Desactivar();
        activadorObjeto.GetComponent<NetworkObject>().Despawn(true);
    }
}
