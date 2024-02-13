using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class DesactivePremioPJ : NetworkBehaviour
{
    public GameObject obj;
   
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
