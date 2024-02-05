using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Plataforma : NetworkBehaviour
{
  private void OnCollisionEnter(Collision collision)
{
    // Si el jugador está en la plataforma, moverlo junto con ella
    if (collision.gameObject.CompareTag("Player"))
    {
            //  collision.transform.SetParent(transform);
            collision.transform.GetComponent<NetworkObject>().TrySetParent(this.NetworkObject);
        }
}

private void OnCollisionExit(Collision collision)
{
    // Si el jugador deja de estar en la plataforma, dejar de moverlo junto con ella
    if (collision.gameObject.CompareTag("Player"))
    {
            //  collision.transform.SetParent(null);
            collision.transform.GetComponent<NetworkObject>().TryRemoveParent(this.NetworkObject);
        }
}

}
