using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class RollingSphere : NetworkBehaviour
{
    public float rotationSpeed = 5f;
    public float speed = 1f;

    void Update()
    {
      RotateSphere();
      TranslateSphere();
    }


    void RotateSphere()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }

    void TranslateSphere()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }

    
}