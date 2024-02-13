using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ColliderDesactive : NetworkBehaviour
{
    private bool band = true;
    [SerializeField ]private DesactivePremioPJ desactive;

    //Si el premio toca un objeto con el siguiente tag, va a desactivar el Premio que lleva el jugador
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Final") && band)
        {
            band = false;
            desactive.DesactiveServerRpc();
        }
    }
}
