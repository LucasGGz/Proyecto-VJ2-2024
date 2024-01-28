using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot1 : Robot
{
    public float speed = 5f;

    public override void Move()
    {
        Debug.Log("Robot1 se está moviendo hacia adelante.");
        // Movimiento de Robot1: Avanza en línea recta
        transform.Translate(Vector3.forward *speed* Time.deltaTime);
    }
}
