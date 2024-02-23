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

    // M�todo llamado en el servidor para iniciar la acci�n en los clientes
    [ServerRpc]
    public void ActionInServerRpc()
    {
        ActionClientRpc();
    }

    // M�todo llamado en los clientes para ejecutar la acci�n
    [ClientRpc]
    public void ActionClientRpc()
    {  
        initialize.InitializeRandom();// Inicializa los objetos 
        StartCoroutine(isortable.Sort(initialize.inst));  // Inicia el proceso de ordenamiento de burbuja en los objetos inicializados
    }
}
