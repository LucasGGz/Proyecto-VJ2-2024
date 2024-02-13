using Unity.Netcode;
using UnityEngine;

public class TuboAnimator : NetworkBehaviour
{
    private string IS_OPEN = "ActivadorAbrio";
    private string IS_CLOSE = "ActivadorCerro";
   
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    // M�todo para reproducir la animaci�n de apertura
    public void IsOpen()
    {
        anim.Play(IS_OPEN);
    }
    // M�todo para reproducir la animaci�n de cierre
    public void IsClosed()
    {
        anim.Play(IS_CLOSE);
    }
}
