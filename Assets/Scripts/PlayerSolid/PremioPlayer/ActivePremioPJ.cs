using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ActivePremioPJ : NetworkBehaviour
{
    public GameObject obj;

    //Metodo que se va a llamar para activar el premio
    //Metodo que tiene el mensaje que se va a enviar a los clientes y de los clientes al server
    [ServerRpc(RequireOwnership = false)]
    public void ActiveServerRpc()
    {
        ActiveClientRpc();
    }

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
