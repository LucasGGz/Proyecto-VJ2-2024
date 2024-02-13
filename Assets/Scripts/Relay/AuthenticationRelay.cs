using System.Collections;
using System.Collections.Generic;
using Unity.Services.Authentication;
using Unity.Services.Core;
using UnityEngine;

public class AuthenticationRelay : MonoBehaviour
{
    // Método de inicio asincrónico que inicializa Unity Relay y maneja la autenticación
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
}
