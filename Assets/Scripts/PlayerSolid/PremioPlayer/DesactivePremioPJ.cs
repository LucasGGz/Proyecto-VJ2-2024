using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class DesactivePremioPJ : NetworkBehaviour
{
    public GameObject obj;
    
    //Metodo que se va a llamar para desactivar el premio
    //Metodo que tiene el mensaje que se va a enviar a los clientes y de los clientes al server
    [ServerRpc(RequireOwnership = false)]
    public void DesactiveServerRpc()
    {
        DesactiveClientRpc();
    }

    // Método RPC para mandar un mensaje a los clientes
    [ClientRpc]
    public void DesactiveClientRpc()
    {
        Desactive();
    }

    public void Desactive()
    {
        //Desactiva el premio
        obj.SetActive(false);
    }

}
