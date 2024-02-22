using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorGenerador : MonoBehaviour
{
    GeneradorObstaculos generadorObstaculos;
    void Start()
    {
        generadorObstaculos = GetComponent<GeneradorObstaculos>();
    }

    public void ActivarGenerador(bool invertido)
    {
        generadorObstaculos.InstantiarObstaculoServerRpc(invertido); // Llama al RPC del servidor para instanciar un obstáculo
    }

}
