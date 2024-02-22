using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

// Este es el script base y contiene la informacion basica sobre el ID del robot.
public abstract class Robot : NetworkBehaviour
{
    [SerializeField] private string id;

    public string Id {get => id;}
   
}