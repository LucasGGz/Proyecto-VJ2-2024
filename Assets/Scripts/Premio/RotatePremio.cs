using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class RotatePremio : NetworkBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0); //hacemos que gire el premio
    }
}
