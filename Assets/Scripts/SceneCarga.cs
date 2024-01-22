using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Unity.Services.Core;
using Unity.Netcode;
using TMPro;

public class SceneCarga : MonoBehaviour
{
    public void game(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}

public class pruebaDef : NetworkBehaviour
{
    [SerializeField] private TMP_Text joincodetext;


    public override void OnNetworkSpawn()
    {
     
    }


    [ServerRpc(RequireOwnership = false)]
    private void pruebaServerRpc()
    {
        
    }
}
