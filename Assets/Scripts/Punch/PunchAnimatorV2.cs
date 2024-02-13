using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchAnimatorV2 : MonoBehaviour
{
   
    private string IS_PunchV2 = "DaElGolpe2";
    private string IS_NoPunchV2 = "GuardaElGolpe2";

    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // M�todo para reproducir la animaci�n de golpe del segundo pu�o
    public void IsPunchV2()
    {
        anim.Play(IS_PunchV2); // Activar la animaci�n de golpe
    }
    // M�todo para reproducir la animaci�n de guardar golpe del segundo pu�o
    public void IsNoPunchV2()
    {
        anim.Play(IS_NoPunchV2); // Activar la animaci�n de guardar golpe
    }
}
