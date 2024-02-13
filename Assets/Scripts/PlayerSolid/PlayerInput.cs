using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    //variables para los inputs y se establecen sus setters y getters
    private float horizontal;
    private float vertical;

    public float Horizontal { get => horizontal; set => horizontal = value; }
    public float Vertical { get => vertical; set => vertical = value; }

  
    void Update()
    {
        //se inicializan los siguientes inputs
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
    }

}
