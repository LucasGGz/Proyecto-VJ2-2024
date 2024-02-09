using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerColor : NetworkBehaviour
{
    [SerializeField] private SkinnedMeshRenderer meshRenderer;
    public List<Color> colors = new List<Color>();
    private void Awake()
    {
        meshRenderer = GetComponentInChildren<SkinnedMeshRenderer>();
    }

    public override void OnNetworkSpawn()
    {

        meshRenderer.material.color = colors[(int)OwnerClientId];
    }
}
