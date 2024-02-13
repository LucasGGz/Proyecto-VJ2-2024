using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;

public class PlayerName : NetworkBehaviour
{
    [SerializeField] private TextMeshProUGUI playerName;
    // Variable de red para almacenar el nombre del jugador
    private NetworkVariable<FixedString128Bytes> networkPlayerName =
        new NetworkVariable<FixedString128Bytes>("Player: 0", NetworkVariableReadPermission.Everyone, NetworkVariableWritePermission.Server);
    public override void OnNetworkSpawn()
    {
        // Establecer el nombre del jugador basado en el ID del cliente propietario
        networkPlayerName.Value = "Player " + (OwnerClientId + 1);
        // Mostrar el nombre del jugador en el componente TextMeshProUGUI
        playerName.text = networkPlayerName.Value.ToString();
    }
}
