using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerRun : NetworkBehaviour
{

    private PlayerMov playerMov;
   
    void Start()
    {
        playerMov = GetComponent<PlayerMov>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            playerMov.Speed = 10f;
        }
        else
        {
            playerMov.Speed = 5f;
        }
    }
}
