using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ButtonCreateHost : NetworkBehaviour
{
    [SerializeField]
    private CreateRelay createRelay;

    //Metodo para Crear el Host a traves del button
    public void CreateHost()
    {
        //Se llama al metodo de la clase CreateRelay que da inicio a el Host
        createRelay.Dale();
    }
}
