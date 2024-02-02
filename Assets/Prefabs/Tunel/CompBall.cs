using Mono.CSharp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompBall : MonoBehaviour
{
   [SerializeField] private Transform pointInitial;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -20)
        {
            transform.position = pointInitial.position;
        }
    }

  
}
