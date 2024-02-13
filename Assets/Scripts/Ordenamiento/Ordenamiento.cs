using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class Ordenamiento : NetworkBehaviour
{
    Invoke invoke;
    private bool genera = true;

    void Start()
    {
      invoke = GetComponent<Invoke>(); // Obtener referencia al componente Invoke
    }
    // Método llamado cuando un objeto con en tag Player ingresa al trigger
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player") && genera)
        {
            invoke.ActionInServerRpc(); //Se llama al metodo que inicia el algoritmo de los objetos instanciados
            Debug.Log("Choco");
            genera = false;
        }
    }
}
