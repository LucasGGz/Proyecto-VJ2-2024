using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class CamSpawn : NetworkBehaviour
{
    public GameObject Camara3era;

    public AudioListener audioListener;
    // Use this for initialization
    public override void OnNetworkSpawn()
    {

        if (IsOwner)
        {
            Camara3era.SetActive(true);
            audioListener.enabled = true;
        }
        else
        {
            Camara3era.SetActive(false);
        }
        base.OnNetworkSpawn();
    }
}
