using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot2 : MonoBehaviour, IRobot
{
    public void Mostrar()
    {
        Instantiate(gameObject, transform.position, transform.rotation);
        Debug.Log("Robot2");
    }
}