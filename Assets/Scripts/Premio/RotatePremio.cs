using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class RotatePremio : NetworkBehaviour
{
    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0); //Hacemos que gire el premio
    }
}
