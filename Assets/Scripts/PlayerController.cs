using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Unity.Netcode;
using TMPro;

public class PlayerController : NetworkBehaviour { 

    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float jumpSpeed;
    [SerializeField] private float range = 5f;
    private float ySpeed;
    private CharacterController controller;
    private Vector3 camForward;
    private Vector3 camRight;
    public GameObject CamaraTerceraPer;
    private Vector3 movePlayer;
    private float horizontal;
    private float vertical;
    private Vector3 playerInput;
    private Vector3 moveDir;
    private Animator anim;

    [SerializeField] private Transform spawnObjectPrefab;
     //[SerializeField] private Transform spawnPelota;
    public AudioListener audioListener;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        //InstantiaPelotaServerRpc();

    }

    private void Update()
    {
        if (!IsOwner) return;

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        playerInput = new Vector3(horizontal, 0, vertical).normalized;
        // playerInput = Vector3.ClampMagnitude(playerInput, 1);
        camDirection();

        moveDir = playerInput.x * camRight + playerInput.z * camForward;
        movePlayer = moveDir * speed;

        if (Input.GetKeyDown(KeyCode.T))
        {
            InstantiaServerRpc();
        }

        // Verificar si moveDir tiene una magnitud suficiente antes de usar LookRotation
        if (moveDir.magnitude > 0.1f)
        {
          
            anim.SetBool("corre", true);
            anim.SetBool("quieto", false);
         //   Debug.Log("En movimiento");
            // Interpolar la rotaci�n de manera suave
            Quaternion targetRotation = Quaternion.LookRotation(moveDir, Vector3.up);
            controller.transform.rotation = Quaternion.Slerp(controller.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
        else
        {
            anim.SetBool("salto", false);
            anim.SetBool("corre", false);
            anim.SetBool("quieto", true);
            //Debug.Log("Quieto");
        }

        // Aplicar la gravedad solo si no est� en el suelo
        if (!controller.isGrounded)
        {
            float gravedad = 9.8f;
            ySpeed += Physics.gravity.y * gravedad * Time.deltaTime;
            
        }
        else
        {
            // Asegurarse de que la velocidad vertical sea negativa cuando est� en el suelo
            ySpeed = -0.5f;
  
            // Manejar el salto mientras est� en el suelo
            if (Input.GetButtonDown("Jump"))
            {
                anim.SetBool("corre", false);
                anim.SetBool("quieto", false);
                anim.SetBool("salto", true);
                ySpeed = jumpSpeed;
                Debug.Log("salte PA");
            }
            else
            {
                anim.SetBool("salto", false);
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }
        // Aplicar movimiento vertical
        movePlayer.y = ySpeed;

        // Aplicar movimiento
        controller.Move(movePlayer * Time.deltaTime);
    }
  /*  void OnTriggerEnter(Collider collider)
    {
        // Verificar si el objeto que colision� tiene la etiqueta "Player"
        if (collider.CompareTag("estructura"))
        {
            InstantiaServerRpc();
            Debug.Log("Choco trigger");
        }
    }*/
    [ServerRpc]
    private void InstantiaServerRpc()
    {
        Transform spawnObjectTransform = Instantiate(spawnObjectPrefab);
        spawnObjectTransform.GetComponent<NetworkObject>().Spawn();

    }

     /*[ServerRpc]
    private void InstantiaPelotaServerRpc()
    {
        Transform spawnObjectTransform = Instantiate(spawnPelota);
        spawnObjectTransform.GetComponent<NetworkObject>().Spawn();

    }*/
  
  
    public override void OnNetworkSpawn()
    {
        UpdatePositionServerRpc();
        if (IsOwner)
        {
            CamaraTerceraPer.SetActive(true);
            audioListener.enabled = true;
        }
        else
        {
            CamaraTerceraPer.SetActive(false);
        }
        base.OnNetworkSpawn();
    }
    
    [ServerRpc(RequireOwnership = false)]
    private void UpdatePositionServerRpc()
    {
        transform.position = new Vector3(UnityEngine.Random.Range(range, -range), 0, UnityEngine.Random.Range(range, -range));
        transform.rotation = new Quaternion(0, 180, 0, 0);
    }

    public void camDirection()
    {
        camForward = CamaraTerceraPer.transform.forward;
        camRight = CamaraTerceraPer.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }
}
