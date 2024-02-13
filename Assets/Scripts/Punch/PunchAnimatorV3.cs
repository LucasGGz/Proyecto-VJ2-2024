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

    // Método para reproducir la animación de golpe del tercer puño
    public void IsPunchV3()
    {
        anim.Play(IS_PunchV3); // Activar la animación de golpe
    }

    // Método para reproducir la animación de guardar golpe del tercer puño
    public void IsNoPunchV3()
    {
        anim.Play(IS_NoPunchV3); // Activar la animación de guardar golpe
    }
}
