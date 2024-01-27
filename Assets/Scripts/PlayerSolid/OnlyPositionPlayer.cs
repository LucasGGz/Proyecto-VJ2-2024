using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class OnlyPositionPlayer : NetworkBehaviour
{

    [SerializeField] private float range = 8f;

    public override void OnNetworkSpawn()
    {
        UpdatePositionServerRpc();
      
    }

    [ServerRpc(RequireOwnership = false)]
    private void UpdatePositionServerRpc()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(range, -range), 0, UnityEngine.Random.Range(range, -range));
        transform.rotation = new Quaternion(0, 180, 0, 0);
    }
}
