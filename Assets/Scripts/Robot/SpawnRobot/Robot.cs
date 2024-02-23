using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este es el script base y contiene la informacion basica sobre el ID del robot.
public abstract class Robot : MonoBehaviour
{
    [SerializeField] private string id;

    public string Id {get => id;}
   
}