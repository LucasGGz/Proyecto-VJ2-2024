using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class PlayerMov : NetworkBehaviour
{
    //Variables nesesarias para el movimiento del Player 
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    private CharacterController controller;
    private Vector3 movePlayer;
    private Vector3 playerInput;
    private Vector3 moveDir;
    //Variables para la obtencion de componentes
    private PlayerAnimator animator;
    private PlayerCamDire camPlayerDire;
    private PlayerInput plaInput;
    private PlayerJump plajump;


    public float Speed { get => speed; set => speed = value; }

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<PlayerAnimator>();
        camPlayerDire = GetComponent<PlayerCamDire>();
        plaInput = GetComponent<PlayerInput>();
        plajump = GetComponent<PlayerJump>();
    }

    private void Update()
    {
        // Si el cliente actual no es el propietario, detiene la ejecucion del resto del codigo
        if (!IsOwner) return;

        playerInput = new Vector3(plaInput.Horizontal, 0, plaInput.Vertical).normalized;
        //Calcular la direccion de movimiento
        moveDir = playerInput.x * camPlayerDire.CamRight + playerInput.z * camPlayerDire.CamForward;
        //Darle al player la direccion de mov y una velocidad
        movePlayer = moveDir * Speed;

        // Verificar si el jugador se mueve o no activara sus respectivas animaciones  
        if (moveDir.magnitude > 0.1f)
        {
            animator.Running = true;

            animator.Walking = false;

            // Rotar suavemente al jugador hacia la dirección de movimiento
            Quaternion targetRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            animator.Running = false;

            animator.Walking = true;

        }

        // Aplicar movimiento vertical
        movePlayer.y = plajump.YSpeed;

        // Aplicar movimiento al jugador
        controller.Move(movePlayer * Time.deltaTime);
    }


}
