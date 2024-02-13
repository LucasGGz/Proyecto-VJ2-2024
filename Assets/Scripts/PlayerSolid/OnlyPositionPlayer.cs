using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class OnlyPositionPlayer : NetworkBehaviour
{
    //Inicializamos el rango a el cual el los player van a poder spawnear
    [SerializeField] private float range = 8f;

    // Método que se ejecuta cuando el jugador se instancia en la red
    public override void OnNetworkSpawn()
    {
        // Llamar al método para actualizar la posición del jugador en el servidor
        UpdatePositionServerRpc();
      
    }

    //Actualizamos la posicion del player de manera random segun un rango y establecemos la rotacion para que nos mire al incializar un player
    [ServerRpc(RequireOwnership = false)]
    private void UpdatePositionServerRpc()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(range, -range), 0, UnityEngine.Random.Range(range, -range));
        transform.rotation = new Quaternion(0, 180, 0, 0);
    }
}
