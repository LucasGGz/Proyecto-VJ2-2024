using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;


// Clase para la lógica de red
public class PuertaNetwork : NetworkBehaviour
{
    [SerializeField] private Animator puertaAnimator;

    [ServerRpc]
    public void ActivarPuertaServerRpc()
    {
        RpcActivarPuertaClientRpc();
    }

    [ClientRpc]
    private void RpcActivarPuertaClientRpc()
    {
        puertaAnimator.Play("PuertaAnimacion");
    }

    [ServerRpc]
    public void DesactivarPuertaServerRpc()
    {
        RpcDesactivarPuertaClientRpc();
    }

    [ClientRpc]
    private void RpcDesactivarPuertaClientRpc()
    {
        puertaAnimator.Play("PuertaCerrar");
    }
}