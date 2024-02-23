using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Netcode;
using UnityEngine;

public class TextChange : NetworkBehaviour
{
    [SerializeField]
    private CreateRelay createRelay;
    [SerializeField]
    private TMP_Text Code;

    // Update is called once per frame
    void Update()
    {
        ChangeCodeTextClientRpc();
    }

    [ClientRpc]
    public void ChangeCodeTextClientRpc()
    {
        Code.text = createRelay.JoinCode; // Actualiza el texto del TMP_Text con el código generado de la clase CreateRelay
    }
}
