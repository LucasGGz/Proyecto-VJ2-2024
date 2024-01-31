using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class Premio : NetworkBehaviour
{
    [SerializeField] private Transform spawnObjectPrefab2;
    private Transform jugadorQueChoco;
    private bool band = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Solo ejecutar el código del propietario
        if (!IsOwner) return;
    }

    void OnTriggerEnter(Collider collider)
    {
        // Verificar si el objeto que colisionó tiene la etiqueta "Player"
        if (collider.CompareTag("Player") && band && IsServer)
        {
            jugadorQueChoco = collider.transform;
            band = false;
            // Llamar a un RPC para instanciar el objeto en todos los clientes
            InstantiaClientRpc();
            Debug.Log("Choco trigger");
        }
    }

    [ClientRpc]
    private void InstantiaClientRpc()
    {
        // Verificar si ya se instanció en este cliente para evitar duplicados
        if (IsServer)
        {
            // Instanciar el objeto en todos los clientes
            Transform spawnObjectTransform = Instantiate(spawnObjectPrefab2);

            // Sincronizar la instancia en la red
            spawnObjectTransform.GetComponent<NetworkObject>().Spawn();

            // Asignar el jugador que chocó como el objetivo a seguir
            ObjectPremio objetoSeguidor = spawnObjectTransform.GetComponent<ObjectPremio>();
            if (objetoSeguidor != null && jugadorQueChoco != null)
            {
                objetoSeguidor.SetJugadorQueChoco(jugadorQueChoco);
            }
        }
    }

}
