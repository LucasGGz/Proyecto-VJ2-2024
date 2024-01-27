using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRun : MonoBehaviour
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
