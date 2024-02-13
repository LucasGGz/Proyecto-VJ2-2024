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

    //Instancia el Premio donde el jugador debera dejar el premio recogido
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Premio") && band)
        {
            band = false;
            win.PremioFinalClientRpc();// Llamar al método RPC en el script IntanciaWin para instanciar el premio final en la red

            Debug.Log("El premio ah sido chcocado y ganaste");
        }
    }
}
