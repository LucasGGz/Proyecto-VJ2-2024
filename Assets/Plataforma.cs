using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
  private void OnCollisionStay(Collision collision)
{
    // Si el jugador está en la plataforma, moverlo junto con ella
    if (collision.gameObject.CompareTag("Player"))
    {
        collision.transform.SetParent(transform);
    }
}

private void OnCollisionExit(Collision collision)
{
    // Si el jugador deja de estar en la plataforma, dejar de moverlo junto con ella
    if (collision.gameObject.CompareTag("Player"))
    {
        collision.transform.SetParent(null);
    }
}

}
