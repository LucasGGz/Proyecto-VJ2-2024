using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class IntanciaWin : NetworkBehaviour
{
    [SerializeField] private Transform PremioFinal;

    // Método RPC para instanciar el premio final en el servidor
    [ServerRpc(RequireOwnership = false)]
    public void PremioFinalInServerRpc()
    {
        PremioFinalClientRpc();
    }

    // Método RPC para instanciar el premio final en los clientes
    [ClientRpc]
    public void PremioFinalClientRpc()
    {
        // Instanciar el premio final en la posición y rotación del objeto local
        Transform spawnObjectTransform = Instantiate(PremioFinal, transform.position, transform.rotation);

        // Sincronizar la instancia en la red
        spawnObjectTransform.GetComponent<NetworkObject>().Spawn();
    }
}
