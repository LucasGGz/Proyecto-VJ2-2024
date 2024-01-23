using UnityEngine;
using Unity.Netcode;

// Maneja la comunicación de red.

public class NetworkActivator : NetworkBehaviour
{
    [SerializeField] private ActivadorObjeto activadorObjeto;

    [ServerRpc]
    private void InstantiaServerRpc()
    {
        activadorObjeto.Activar();
        activadorObjeto.GetComponent<NetworkObject>().Spawn();
    }

    [ServerRpc]
    private void DesactivarServerRpc()
    {
        activadorObjeto.Desactivar();
        activadorObjeto.GetComponent<NetworkObject>().Despawn(true);
    }
}
