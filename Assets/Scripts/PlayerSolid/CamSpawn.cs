using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class CamSpawn : NetworkBehaviour
{
    public GameObject Camara3era;

    //Metodo de NetworkBehaviour para que se ejecute en red
    public override void OnNetworkSpawn()
    {
        //Si somos el propietario de ese GO
        if (IsOwner)
        {
            // Habilitar la cámara si somos el propietario
            Camara3era.SetActive(true);
        }
        else
        {
            //sino lo somos desactivamos
            Camara3era.SetActive(false);
        }
        base.OnNetworkSpawn();
    }
}
