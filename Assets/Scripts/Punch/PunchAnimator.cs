using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PunchAnimator : NetworkBehaviour
{
    private string IS_Punch = "DaElGolpe";
    private string IS_NoPunch = "GuardaElGolpe";

    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Método para reproducir la animación de golpe
    public void IsPunch()
    {
        anim.Play(IS_Punch); // Activar la animación de golpe
    }

    // Método para reproducir la animación de guardar golpe
    public void IsNoPunch()
    {
        anim.Play(IS_NoPunch);  // Activar la animación de guardar golpe
    }
}
