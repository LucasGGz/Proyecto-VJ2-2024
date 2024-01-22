/*using UnityEngine;
using Unity.Netcode;

public class ActivarObjeto : NetworkBehaviour
{
    [SerializeField] private GameObject spawnObjectPrefab; // Cambié de Transform a GameObject

    private GameObject spawnedObject; // Variable para almacenar la instancia del objeto

    private void Awake()
    {
        // Al inicio del juego, asegúrate de que el objeto esté desactivado
        if (IsServer)
        {
            spawnedObject = Instantiate(spawnObjectPrefab, transform.position, Quaternion.identity);
            spawnedObject.GetComponent<NetworkObject>().Spawn();
            spawnedObject.SetActive(false);
        }
    }

    [ServerRpc]
    private void InstantiaServerRpc()
    {
        // Si ya existe una instancia del objeto, simplemente actívalo en el servidor
        if (spawnedObject != null)
        {
            spawnedObject.SetActive(true);
        }
        else
        {
            // Instancia el objeto en la posición actual del objeto que tiene este script en el servidor
            spawnedObject = Instantiate(spawnObjectPrefab, transform.position, Quaternion.identity);
            
            // Sincroniza la instanciación en la red
            spawnedObject.GetComponent<NetworkObject>().Spawn();
            
            // Puedes realizar más acciones aquí si es necesario, como modificar propiedades del spawnedObject
        }
    }

    [ServerRpc]
    private void DesactivarServerRpc()
    {
        // Desactiva el objeto cuando deja de haber trigger en el servidor
        if (spawnedObject != null)
        {
            spawnedObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Punto")
        {
            Debug.Log("Choco");
            InstantiaServerRpc();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Punto")
        {
            Debug.Log("FUE");
            DesactivarServerRpc();
        }
    }
}*/


using UnityEngine;
using Unity.Netcode;

public class ActivarObjeto : NetworkBehaviour
{
    [SerializeField] private Transform spawnObjectPrefab;
    private Transform spawnedObject;

    [ServerRpc]
    private void InstantiaServerRpc()
    {
        // Verifica si ya hay una instancia creada
        if (spawnedObject == null)
        {
            spawnedObject = Instantiate(spawnObjectPrefab);
            spawnedObject.GetComponent<NetworkObject>().Spawn();
        }
    }

    [ServerRpc]
    private void DesactivarServerRpc()
    {
        // Verifica si hay una instancia antes de intentar desactivarla
        if (spawnedObject != null)
        {
            spawnedObject.GetComponent<NetworkObject>().Despawn(true);
            // Puedes destruir el objeto si es necesario
            // Destroy(spawnedObject.gameObject);
            // Y también establecer spawnedObject en null para futuras instancias
            spawnedObject = null;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Punto"))
        {
            Debug.Log("Choco");
            InstantiaServerRpc();
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Punto"))
        {
            Debug.Log("FUE");
            DesactivarServerRpc();
        }
    }
}
