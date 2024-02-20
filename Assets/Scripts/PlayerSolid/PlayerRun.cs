using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerRun : NetworkBehaviour
{
    private PlayerMov playerMov;
   
    void Start()
    {
        playerMov = GetComponent<PlayerMov>(); //obtengo el script
    }

    void Update()
    {
        //Con el shift el jugador podra correr y se modifica el valor de la variable speed del script PlayerMov
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
