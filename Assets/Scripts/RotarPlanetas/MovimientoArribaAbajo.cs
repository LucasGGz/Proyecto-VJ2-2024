using UnityEngine;

public class MovimientoArribaAbajo : MonoBehaviour
{
    public float velocidad = 1.0f; // Velocidad del movimiento
    public float rango = 1.0f; // Rango de movimiento

    private Vector3 posicionInicial;

    void Start()
    {
        // Guarda la posición inicial del objeto
        posicionInicial = transform.position;
    }

    void Update()
    {
        // Calcula la posición objetivo basada en la posición inicial y el rango
        Vector3 posicionObjetivo = posicionInicial + Vector3.up * Mathf.Sin(Time.time * velocidad) * rango;

        // Mueve el objeto hacia la posición objetivo
        transform.position = posicionObjetivo;
    }
}

