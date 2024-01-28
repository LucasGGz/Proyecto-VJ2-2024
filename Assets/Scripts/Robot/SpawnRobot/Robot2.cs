using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Robot2 : Robot
{
     public override void Move()
    {
        // Implementa el movimiento específico para Robot1
        Debug.Log("Robot2 se está moviendo hacia adelante.");
        transform.Rotate(Vector3.up, -1.0f);
    }
}
