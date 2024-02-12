using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

// Este es el script base para un robot.
public abstract class Robot : NetworkBehaviour
{
    [SerializeField] private string id;

    public string Id {get => id;}
   
}