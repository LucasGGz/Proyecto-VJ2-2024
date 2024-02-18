using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PunchV2 : NetworkBehaviour
{
    private PunchAnimatorV2 PunchAnimV2;
    void Start()
    {
        PunchAnimV2 = GetComponent<PunchAnimatorV2>();
    }

    // Método llamado cuando el objeto se instancia en la red
    public override void OnNetworkSpawn()
    {
        if (IsOwner)
        {
            MechanismPunchInServerRpc();
        }
    }

    // Método RPC para iniciar el mecanismo de golpes en el servidor
    [ServerRpc]
    public void MechanismPunchInServerRpc()
    {
        StartCoroutine(PunchGo());
    }

    // Corrutina que controla el mecanismo de golpes
    public IEnumerator PunchGo()
    {
        while (true)
        {
            // Reproducir la primera animación
            PunchAnimV2.IsPunchV2();
            // Esperar un tiempo aleatorio antes de reproducir la segunda animación
            float tiempoEspera = Random.Range(1f, 3f);
            yield return new WaitForSeconds(tiempoEspera);

            // Reproducir la segunda animación
            PunchAnimV2.IsNoPunchV2();
            float tiempoEspera2 = Random.Range(2f, 3f);
            yield return new WaitForSeconds(tiempoEspera2);
        }
    }
}
