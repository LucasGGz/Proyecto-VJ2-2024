using QFSW.QC;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode.Transports.UTP;
using Unity.Netcode;
using Unity.Networking.Transport.Relay;
using Unity.Services.Relay.Models;
using Unity.Services.Relay;
using UnityEngine;

public class RelayJoin : MonoBehaviour
{
    // Comando para unirse a un servidor de relay existente
    [Command]
    public async void JoinRelay(string joinCode)
    {
        try
        {
            // Intenta unirse a una asignación de Relay con el código de unión proporcionado
            Debug.Log("Joining with relay code" + joinCode);
            JoinAllocation joinAllocation = await RelayService.Instance.JoinAllocationAsync(joinCode);

            // Configura el cliente para el transporte de Unity y lo inicia
            RelayServerData relayServerData = new RelayServerData(joinAllocation, "dtls");
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(relayServerData);

            NetworkManager.Singleton.StartClient(); //Inicia el cliente que se vaya a unir
        }
        catch (RelayServiceException e)
        {
            Debug.Log("error " + e);
        }
    }
}
