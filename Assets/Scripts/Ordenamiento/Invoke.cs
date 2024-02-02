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

    public void Action()
    {
        initialize.InitializeRandom();
        StartCoroutine(isortable.BubbleSort(initialize.inst));
    }
}
