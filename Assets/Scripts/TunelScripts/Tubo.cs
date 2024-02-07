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

    public override void OnNetworkSpawn()
    {
        MechanismInServerRpc();
    }

    [ServerRpc]
    public void MechanismInServerRpc()
    {
        StartCoroutine(Mechanism());
    }


    public IEnumerator Mechanism()
    {
        while (true)
        {
            // Reproducir la primera animación
            //animator.Play("vino");
            tuboAnim.IsOpen();

            // Esperar un tiempo aleatorio antes de reproducir la segunda animación
            float tiempoEspera = Random.Range(3f, 5f);
            yield return new WaitForSeconds(tiempoEspera);
  
            // Reproducir la segunda animación
            //animator.Play("salio");
            tuboAnim.IsClosed();
            float tiempoEspera2 = Random.Range(3f, 5f);
            yield return new WaitForSeconds(tiempoEspera2);
        }
    }
}
