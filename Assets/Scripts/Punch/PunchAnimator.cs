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

    public void IsPunch()
    {
        anim.Play(IS_Punch);
    }
    public void IsNoPunch()
    {
        anim.Play(IS_NoPunch);
    }
}
