using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ActivePremioPJ : NetworkBehaviour
{
    public GameObject obj;

    void Start()
    {

    }

    [ServerRpc(RequireOwnership = false)]
    public void ActiveServerRpc()
    {
        ActiveClientRpc();
    }


    [ClientRpc]
    public void ActiveClientRpc()
    {
        Active();
    }

    public void Active()
    {

        obj.SetActive(true);
    }

}
