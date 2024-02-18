using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Tubo : NetworkBehaviour
{
    TuboAnimator tuboAnim;
    void Start()
    {
        tuboAnim = GetComponent<TuboAnimator>();
    }

    // Método llamado cuando el objeto se instancia en la red
    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            MechanismInServerRpc();
        }
    }

    // Método RPC para iniciar el mecanismo en el servidor
    [ServerRpc]
    public void MechanismInServerRpc()
    {
        StartCoroutine(Mechanism());
    }

    // Corrutina que controla el mecanismo del tubo
    public IEnumerator Mechanism()
    {
        while (true)
        {
            // Reproducir la primera animación
            tuboAnim.IsOpen();

            // Esperar un tiempo aleatorio antes de reproducir la segunda animación
            float tiempoEspera = Random.Range(3f, 5f);
            yield return new WaitForSeconds(tiempoEspera);
  
            // Reproducir la segunda animación
            tuboAnim.IsClosed();
            float tiempoEspera2 = Random.Range(3f, 5f);
            yield return new WaitForSeconds(tiempoEspera2);
        }
    }
}
