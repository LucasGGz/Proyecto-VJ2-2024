using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Interfaz IMovable que define un metodo de movimiento.
public interface IMovable
{
   void Move(Transform transform, float speed);
}
