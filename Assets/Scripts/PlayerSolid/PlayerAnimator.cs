using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimator : NetworkBehaviour
{
    private string IS_WALKING = "quieto";
    private string IS_RRUNNING = "corre";
    private string IS_JUMPING = "salto";
    private Animator animator;

    private bool walking;
    private bool running;
    private bool jumping;

    public bool Walking { get => walking; set => walking = value; }
    public bool Running { get => running; set => running = value; }
    public bool Jumping { get => jumping; set => jumping = value; }

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!IsOwner) return;
        animator.SetBool(IS_WALKING, IsWalking());
        animator.SetBool(IS_RRUNNING, IsRunning());
        animator.SetBool(IS_JUMPING, IsJumping());
    }

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
