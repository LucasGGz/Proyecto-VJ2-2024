using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMov : MonoBehaviour
{
    private Vector2 angle = new Vector2(90 * Mathf.Deg2Rad, 0); //para que se situe atras del pj al comienzo y mover en y en x
    public Vector2 sens;
    public Vector2 Angle { get => angle; set => angle = value; }
    CamaraInput camaraInput;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        camaraInput = GetComponent<CamaraInput>();
    }

    void Update()
    {
        //movimiento en x e y con el mouse
        if (camaraInput.Hor != 0)
        {
            angle.x += camaraInput.Hor * Mathf.Deg2Rad * sens.x;
        }

        if (camaraInput.Ver != 0)
        {
            angle.y += camaraInput.Ver * Mathf.Deg2Rad * sens.y;
            angle.y = Mathf.Clamp(Angle.y, -80 * Mathf.Deg2Rad, 80 * Mathf.Deg2Rad); //para que la cam no se pase de ciertos valores
        }
    }
}
