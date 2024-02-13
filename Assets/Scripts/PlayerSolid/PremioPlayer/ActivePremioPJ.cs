using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ActivePremioPJ : NetworkBehaviour
{
    public GameObject obj;

    // Método RPC para mandar un mensaje a los clientes
    [ClientRpc]
    public void ActiveClientRpc()
    {
        Active();
    }

    public void Active()
    {
        //Activa el premio
        obj.SetActive(true);
    }

}
