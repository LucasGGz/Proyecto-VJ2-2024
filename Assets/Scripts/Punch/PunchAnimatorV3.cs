using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchAnimatorV3 : MonoBehaviour
{
    private string IS_PunchV3 = "DaElGolpe3";
    private string IS_NoPunchV3 = "GuardaElGolpe3";

    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // M�todo para reproducir la animaci�n de golpe del tercer pu�o
    public void IsPunchV3()
    {
        anim.Play(IS_PunchV3); // Activar la animaci�n de golpe
    }

    // M�todo para reproducir la animaci�n de guardar golpe del tercer pu�o
    public void IsNoPunchV3()
    {
        anim.Play(IS_NoPunchV3); // Activar la animaci�n de guardar golpe
    }
}
