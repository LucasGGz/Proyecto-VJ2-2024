using UnityEngine;
using Unity.Netcode;

// Maneja la comunicación de red para la creación de robots.

public class NetworkRobot : NetworkBehaviour
{
    public GameObject[] robotPrefabs; // Array de prefabs de robot

    [ServerRpc]
    private void SpawnAllRobotsServerRpc()
    {
        for (int i = 0; i < robotPrefabs.Length; i++)
        {
            GameObject prefabToSpawn = robotPrefabs[i];
            GameObject newRobot = Instantiate(prefabToSpawn, transform.position, transform.rotation);
            
            NetworkObject networkObject = newRobot.GetComponent<NetworkObject>();
            networkObject.Spawn();
        }
    }

    void Start()
    {
        // Utilizando la fábrica de Robot1
        IFabricaRobot fabricaRobot1 = new FabricaRobot1();
        IRobot robot1 = fabricaRobot1.CrearRobot();
        robot1.Mostrar();

        // Utilizando la fábrica de Robot2
        IFabricaRobot fabricaRobot2 = new FabricaRobot2();
        IRobot robot2 = fabricaRobot2.CrearRobot();
        robot2.Mostrar();

        // Llamando a la función de spawn para todos los robots en red
        if (IsServer)
        {
            SpawnAllRobotsServerRpc();
        }
    }
}
