using QFSW.QC;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode.Transports.UTP;
using Unity.Netcode;
using Unity.Networking.Transport.Relay;
using Unity.Services.Relay.Models;
using Unity.Services.Relay;
using UnityEngine;

public class CreateRelay : MonoBehaviour
{
    private string joinCode;

    public string JoinCode { get => joinCode; set => joinCode = value; }

    // Comando para iniciar un servidor de relay
    [Command]
    public async void Dale()
    {
        try
        {
            // Crea una asignación de Relay para dos jugadores
            Allocation allocation = await RelayService.Instance.CreateAllocationAsync(2);
            // Obtiene el código de unión de la asignación y lo imprime en la consola
            JoinCode = await RelayService.Instance.GetJoinCodeAsync(allocation.AllocationId);
            Debug.Log(JoinCode);

            // Configura el servidor de relay para el transporte de Unity y lo inicia
            var relayServerData = new RelayServerData(allocation, "dtls");
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(relayServerData);

            NetworkManager.Singleton.StartHost(); // Inicia el host
        }
        catch (RelayServiceException e)
        {
            Debug.Log("error " + e);
        }
    }

}
