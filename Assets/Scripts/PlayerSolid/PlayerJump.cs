using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class PlayerJump : NetworkBehaviour
{
    private CharacterController controller;
    [SerializeField] private float jumpSpeed;
    private float ySpeed;


    private PlayerAnimator animator;

    public float YSpeed { get => ySpeed; set => ySpeed = value; }


    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<PlayerAnimator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsOwner) return;
        // Aplicar la gravedad solo si no está en el suelo, en el else
        if (controller.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                YSpeed = -0.5f;
                animator.Running = false;
                animator.Walking = false;
                animator.Jumping = true;

                YSpeed = jumpSpeed;
                Debug.Log("salte PA");
            }
            else
            {
                animator.Jumping = false;
            }
        }
        else
        {
            // Asegurarse de que la velocidad vertical sea negativa cuando está en el suelo
            float gravedad = 9.8f;
            YSpeed += Physics.gravity.y * gravedad * Time.deltaTime;
        }
    }
}
