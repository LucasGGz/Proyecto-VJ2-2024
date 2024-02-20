using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimator : NetworkBehaviour
{
    // Nombres de los parámetros de las animaciones en el Animator Controller
    private string IS_WALKING = "quieto";
    private string IS_RRUNNING = "corre";
    private string IS_JUMPING = "salto";
    private Animator animator;
    // Variables booleanas para activar o desactivar las animaciones desde otros scripts
    private bool walking;
    private bool running;
    private bool jumping;
    //Sus setters y getters
    public bool Walking { get => walking; set => walking = value; }
    public bool Running { get => running; set => running = value; }
    public bool Jumping { get => jumping; set => jumping = value; }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!IsOwner) return; // Verificar si este objeto es el dueño en la red

        //Pasamos la variable de tipo string y su metodo correspondiente
        animator.SetBool(IS_WALKING, IsWalking());
        animator.SetBool(IS_RRUNNING, IsRunning());
        animator.SetBool(IS_JUMPING, IsJumping());
    }

    //estos metodos van a retornar el valor del booleano que se inicializan en los diferentes scripts
    public bool IsWalking()
    {
        return Walking;
    }
    public bool IsRunning()
    {
        return Running;
    }
    public bool IsJumping()
    {
        return Jumping;
    }
}
