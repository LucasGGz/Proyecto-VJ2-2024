using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public abstract class Robot : NetworkBehaviour
{
    [SerializeField] private string id;

    public string Id {get => id;}
   
   /*   // Método concreto que llama al método abstracto
    [ServerRpc]
    public virtual void MoveServerRpc()
    {
        Move();
    }

    // Método abstracto para el movimiento
    public abstract void Move();*/

}