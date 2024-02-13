using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerColor : NetworkBehaviour
{
    [SerializeField] private SkinnedMeshRenderer meshRenderer;
    //Lista de colores que asignamos en el Inspector
    public List<Color> colors = new List<Color>();
    private void Awake()
    {
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>(); //Obtenemos el meshRenderer del GO del player
    }

    // Método que se llama cuando el jugador se instancia en la red
    public override void OnNetworkSpawn()
    {
        // Asignar el color del jugador basado en el ID del cliente propietario
        // El ID del cliente propietario se utiliza como índice para seleccionar un color de la lista de colores
        meshRenderer.material.color = colors[(int)OwnerClientId];
    }
}
