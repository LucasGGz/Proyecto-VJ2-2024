using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class IntanciaWin : NetworkBehaviour
{
    [SerializeField] private Transform PremioFinal;
   


    [ServerRpc(RequireOwnership = false)]
    public void PremioFinalServerRpc()
    {
        Transform spawnObjectTransform = Instantiate(PremioFinal,transform.position,transform.rotation);

        // Sincronizar la instancia en la red
        spawnObjectTransform.GetComponent<NetworkObject>().Spawn();
    }
}
