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

    [ServerRpc(RequireOwnership = false)]
    public void MechanismInServerRpc()
    {
        StartCoroutine(Mechanism());
    }


    public IEnumerator Mechanism()
    {
        while (true)
        {
            // Reproducir la primera animaci�n
            //animator.Play("vino");
            tuboAnim.IsOpen();

            // Esperar un tiempo aleatorio antes de reproducir la segunda animaci�n
            float tiempoEspera = Random.Range(1f, 2f);
            yield return new WaitForSeconds(tiempoEspera);

            // Reproducir la segunda animaci�n
            //animator.Play("salio");
            tuboAnim.IsClosed();
            float tiempoEspera2 = Random.Range(2f, 5f);
            yield return new WaitForSeconds(tiempoEspera2);
        }
    }
}
