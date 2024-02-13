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

    // M�todo para reproducir la animaci�n de golpe
    public void IsPunch()
    {
        anim.Play(IS_Punch); // Activar la animaci�n de golpe
    }

    // M�todo para reproducir la animaci�n de guardar golpe
    public void IsNoPunch()
    {
        anim.Play(IS_NoPunch);  // Activar la animaci�n de guardar golpe
    }
}
