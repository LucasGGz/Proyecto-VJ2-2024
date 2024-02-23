using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Invoke : NetworkBehaviour
{
    //Interfaces para la inicializacion y el algoritmo
    Initialize initialize;
    Isortable isortable;
    void Start()
    {
        // Obtener referencias a los componentes Initialize e Isortable
        initialize = GetComponent<Initialize>();
        isortable = GetComponent<Bubble>();
    }

    // Método llamado en el servidor para iniciar la acción en los clientes
    [ServerRpc]
    public void ActionInServerRpc()
    {
        ActionClientRpc();
    }

    // Método llamado en los clientes para ejecutar la acción
    [ClientRpc]
    public void ActionClientRpc()
    {  
        initialize.InitializeRandom();// Inicializa los objetos 
        StartCoroutine(isortable.Sort(initialize.inst));  // Inicia el proceso de ordenamiento de burbuja en los objetos inicializados
    }
}
