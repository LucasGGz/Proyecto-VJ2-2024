using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Authentication;
using Unity.Services.Relay;
using Unity.Services.Relay.Models;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using Unity.Networking.Transport.Relay;
using TMPro;
using QFSW.QC;
public class TestRelay : MonoBehaviour
{
  /*  // Método de inicio asincrónico que inicializa Unity Relay y maneja la autenticación
    private async void Start()
    {
        // Inicializa Unity Relay
        await UnityServices.InitializeAsync();

        // Suscribe un evento para visualizar el inicio de sesión y la autenticación anónima
        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log("signed in " + AuthenticationService.Instance.PlayerId);
        };

        await AuthenticationService.Instance.SignInAnonymouslyAsync();  // Inicia sesión de forma anónima
    }

    // Comando para iniciar un servidor de relay
    [Command]
    public async void Dale()
    {
        try
        {
            // Crea una asignación de Relay para dos jugadores
            Allocation allocation = await RelayService.Instance.CreateAllocationAsync(2);
            // Obtiene el código de unión de la asignación y lo imprime en la consola
            string joinCode = await RelayService.Instance.GetJoinCodeAsync(allocation.AllocationId);
            Debug.Log(joinCode);

            // Configura el servidor de relay para el transporte de Unity y lo inicia
            var relayServerData = new RelayServerData(allocation,"dtls");
            NetworkManager.Singleton.GetComponent<UnityTransport>().SetRelayServerData(relayServerData);

            NetworkManager.Singleton.StartHost(); // Inicia el host
        }
        catch (RelayServiceException e)
        {
            Debug.Log("error " + e);
        }
    }

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
    }*/
}