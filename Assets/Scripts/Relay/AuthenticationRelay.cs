using System.Collections;
using System.Collections.Generic;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

public class AuthenticationRelay : MonoBehaviour
{
    // M�todo de inicio asincr�nico que inicializa Unity Relay y maneja la autenticaci�n
    private async void Start()
    {
        // Inicializa Unity Relay
        await UnityServices.InitializeAsync();

        // Suscribe un evento para visualizar el inicio de sesi�n y la autenticaci�n an�nima
        AuthenticationService.Instance.SignedIn += () =>
        {
            Debug.Log("signed in " + AuthenticationService.Instance.PlayerId);
        };

        await AuthenticationService.Instance.SignInAnonymouslyAsync();  // Inicia sesi�n de forma an�nima
    }
}
