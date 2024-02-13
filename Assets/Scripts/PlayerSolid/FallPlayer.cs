using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class FallPlayer : NetworkBehaviour
{
    FallPlayerPoints fallPoints;
    void Start()
    {
        fallPoints= GetComponent<FallPlayerPoints>();   //obtenemos los puntos
    }

    void Update()
    {
        if (!IsOwner) return;
        // Verificar si el jugador ha ca�do por debajo de cierta altura
        if (transform.position.y <= -40f)
        {
            // Y determinar la posici�n a la que se teletransportar� el jugador seg�n su posici�n en el eje Z o en X
            if (transform.position.z > 407)
            {
                transform.position = fallPoints.Point9;
            }
            else if (transform.position.z > 330)
            {
                transform.position = fallPoints.Point8;
            }
            else if (transform.position.z > 248)
            {
                transform.position = fallPoints.Point7;
            }
            else if (transform.position.z > 207f)
            {
                transform.position = fallPoints.Point6;
            }
            else if (transform.position.z > 158 && transform.position.x > 196f)
            {
                transform.position = fallPoints.Point5;
            }
            else if (transform.position.z > 158 && transform.position.x > 84)
            {
                transform.position = fallPoints.Point4;
            }
            else if (transform.position.z > 158)
            {
                transform.position = fallPoints.Point3;
            }
            else if (transform.position.z > 62)
            {
                if (transform.position.x > 44)
                {
                    transform.position = fallPoints.PointV2;
                }
                else
                {
                    transform.position = fallPoints.Point2;
                }
            }
            else
            {
                // Si el jugador no est� en una posici�n especial, teletransportarlo al l�mite predeterminado
                transform.position = fallPoints.Point;
            }

            Debug.Log("Se cay�");
        }
    }
}
