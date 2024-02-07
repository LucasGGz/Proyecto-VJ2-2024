using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Invoke : NetworkBehaviour
{
    Initialize initialize;
    Isortable isortable;
    void Start()
    {
       initialize = GetComponent<Initialize>();
        isortable = GetComponent<Isortable>();
    }

    [ServerRpc]
    public void ActionInServerRpc()
    {
        ActionClientRpc();
    }

    [ClientRpc]
    public void ActionClientRpc()
    {
        initialize.InitializeRandom();
        StartCoroutine(isortable.BubbleSort(initialize.inst));
    }
}
