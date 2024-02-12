using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clase abstracta BaseMovimiento que implementa la interfaz IMovable.
public abstract class BaseMovimiento : IMovable
{
    public abstract void Move(Transform transform, float speed);
}
