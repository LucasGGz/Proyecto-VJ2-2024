using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.Netcode;
using UnityEngine;

public class PlayerMov : NetworkBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    private CharacterController controller;
    private Vector3 movePlayer;
    private Vector3 playerInput;
    private Vector3 moveDir;

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

        if (!IsOwner) return;


        playerInput = new Vector3(plaInput.Horizontal, 0, plaInput.Vertical).normalized;
        // playerInput = Vector3.ClampMagnitude(playerInput, 1);


        moveDir = playerInput.x * camPlayerDire.CamRight + playerInput.z * camPlayerDire.CamForward;
        movePlayer = moveDir * Speed;

        /* if (Input.GetKeyDown(KeyCode.T))
         {
             InstantiaServerRpc();
         }*/


        // Verificar si moveDir tiene una magnitud suficiente antes de usar LookRotation
        if (moveDir.magnitude > 0.1f)
        {
            animator.Running = true;

            animator.Walking = false;

            // Interpolar la rotación de manera suave
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

        // Aplicar movimiento
        controller.Move(movePlayer * Time.deltaTime);
    }


}
