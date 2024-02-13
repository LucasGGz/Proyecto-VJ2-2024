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

    // Método para reproducir la animación de golpe del segundo puño
    public void IsPunchV2()
    {
        anim.Play(IS_PunchV2); // Activar la animación de golpe
    }
    // Método para reproducir la animación de guardar golpe del segundo puño
    public void IsNoPunchV2()
    {
        anim.Play(IS_NoPunchV2); // Activar la animación de guardar golpe
    }
}
