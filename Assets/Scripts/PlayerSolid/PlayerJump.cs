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
        //Obtengo el controller y el script animator que tiene el control de las animaciones
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
            //Con el espacio el jugador podra saltar, se activan o desactivan las animaciones
            if (Input.GetButtonDown("Jump"))
            {
                animator.Running = false;
                animator.Walking = false;
                animator.Jumping = true;
                // Se aplica la velocidad de salto al jugador
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
            // Se aplica la gravedad al jugador cuando no está en el suelo
            float gravedad = 9.8f;
            YSpeed += Physics.gravity.y * gravedad * Time.deltaTime;
        }
    }
}
