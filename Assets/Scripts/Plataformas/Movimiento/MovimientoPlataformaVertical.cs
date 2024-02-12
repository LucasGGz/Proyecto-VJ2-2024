using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movimiento de Plataforma Vertical
public class MovimientoPlataformaVertical : IMovimientoPlataforma
{
    public float velocidad = 1.0f;
    public float rango = 1.0f; 

    private Vector3 posicionInicial;

    // Constructor que guarda la posición inicial del objeto
    public MovimientoPlataformaVertical(Transform transform)
    {
        posicionInicial = transform.position;
    }

    // Método para mover la plataforma
    public void Mover(Transform transform)
    {
        Vector3 posicionObjetivo = posicionInicial + Vector3.up * Mathf.Sin(Time.time * velocidad) * rango;

        transform.position = posicionObjetivo;
    }
}
