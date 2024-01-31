using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class DesactivePremioPJ : NetworkBehaviour
{
    public GameObject obj;
    void Start()
    {
        
    }

    

    [ServerRpc(RequireOwnership = false)]
    public void DesactiveServerRpc()
    {
        DesactiveClientRpc();
    }


    [ClientRpc]
    public void DesactiveClientRpc()
    {
        Desactive();
    }

    public void Desactive()
    {

        obj.SetActive(false);
    }

}
