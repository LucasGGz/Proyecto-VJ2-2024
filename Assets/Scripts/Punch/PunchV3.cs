using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PunchV3 : NetworkBehaviour
{
    private PunchAnimatorV3 PunchAnimV3;
    void Start()
    {
        PunchAnimV3 = GetComponent<PunchAnimatorV3>();
    }

    // M�todo llamado cuando el objeto se instancia en la red
    public override void OnNetworkSpawn()
    {
        MechanismPunchInServerRpc();
    }

    // M�todo RPC para iniciar el mecanismo de golpes en el servidor
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
            // Reproducir la primera animaci�n
            PunchAnimV3.IsPunchV3();
            // Esperar un tiempo aleatorio antes de reproducir la segunda animaci�n
            float tiempoEspera = Random.Range(1f, 3f);
            yield return new WaitForSeconds(tiempoEspera);

            // Reproducir la segunda animaci�n          
            PunchAnimV3.IsNoPunchV3();
            float tiempoEspera2 = Random.Range(2f, 3f);
            yield return new WaitForSeconds(tiempoEspera2);
        }
    }
}
