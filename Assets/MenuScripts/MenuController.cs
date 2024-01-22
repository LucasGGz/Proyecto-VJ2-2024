using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public ButtonInvoker startButton;
   
    void Start()
    {
        // Configura el botón de inicio con el comando para cambiar a la escena del juego
        ICommand changeSceneCommand = new ChangeSceneCommand("SampleScene");
        startButton.SetCommand(changeSceneCommand);

    }
}