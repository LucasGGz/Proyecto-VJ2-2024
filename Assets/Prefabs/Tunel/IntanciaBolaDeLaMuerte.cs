using Unity.Netcode;
using UnityEngine;


public class IntanciaBolaDeLaMuerte : NetworkBehaviour
{
    [SerializeField] private Transform spawnBall;
    //private bool band=true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public override void OnNetworkSpawn()
    {

        InstantiaBallServerRpc();

    }


    /* private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("Player") && band)
         {
             band = false;   
             InstantiaBallServerRpc();
             Destroy(this.gameObject);
         }

     }*/

    [ServerRpc]
    private void InstantiaBallServerRpc()
    {
        Transform spawnObjectTransform = Instantiate(spawnBall);
        spawnObjectTransform.GetComponent<NetworkObject>().Spawn();

    }
}
