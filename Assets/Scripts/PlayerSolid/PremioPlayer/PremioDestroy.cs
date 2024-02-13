using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremioDestroy : MonoBehaviour
{
    //Si choca con algun jugador va a destruir el Premio a recoger
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }
}
