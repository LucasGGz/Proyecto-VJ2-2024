using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlataformaVertical : IMovimientoPlataforma
{
    public float velocidad = 1.0f; // Velocidad del movimiento
    public float rango = 1.0f; // Rango de movimiento

    private Vector3 posicionInicial;

    public MovimientoPlataformaVertical(Transform transform)
    {
        // Guarda la posición inicial del objeto
        posicionInicial = transform.position;
    }

    public void Mover(Transform transform)
    {
        // Calcula la posición objetivo basada en la posición inicial y el rango
        Vector3 posicionObjetivo = posicionInicial + Vector3.up * Mathf.Sin(Time.time * velocidad) * rango;

        // Mueve el objeto hacia la posición objetivo
        transform.position = posicionObjetivo;
    }
}
