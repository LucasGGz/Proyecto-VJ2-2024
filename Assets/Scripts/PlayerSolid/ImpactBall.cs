using Unity.Netcode;
using UnityEngine;


public class ImpactBall : NetworkBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
     
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BallDead")
        {
            InitialServerRpc();
            
        
        }
    }
    [ServerRpc(RequireOwnership =false)]
    public void InitialServerRpc()
    {
        Debug.Log("Teletransportado a (0, 0, 0)");
        transform.position = Vector3.zero;
    }
}
