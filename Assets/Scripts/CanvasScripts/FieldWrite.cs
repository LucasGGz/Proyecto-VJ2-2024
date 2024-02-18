using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;

public class FieldWrite : NetworkBehaviour
{
    [SerializeField]
    private TMP_InputField inputField;
    [SerializeField]
    private RelayJoin relayJoin;
  
    //Metodo para que podamos ingresar el code en el inputField
    public void InsertCodeRelay()
    {
        // Obtener el texto del InputField
        string texto = inputField.text;

        // Llamar al método JoinRelay de la clase RelayJoin pasando el texto como parámetro
        relayJoin.JoinRelay(texto);
    }
}
