using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class InstanciaColliderWin : NetworkBehaviour
{
    private bool band = true;
    IntanciaWin win;

    private void Start()
    {
        win = GetComponent<IntanciaWin>();  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Premio") && band)
        {
            band = false;
            win.PremioFinalServerRpc();

            Debug.Log("El premio ah sido chcocado y ganaste");
        }
    }
}
