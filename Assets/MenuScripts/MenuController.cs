using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public ButtonInvoker startButton;
    public ButtonInvoker quitButton;

    void Start()
    {
        // Configura el bot�n de inicio con el comando para cambiar a la escena del juego
        ICommand changeSceneCommand = new ChangeSceneCommand("SampleScene");
        startButton.SetCommand(changeSceneCommand);

        // Configura el bot�n "Quit" con el comando para salir del juego
        ICommand quitGameCommand = new QuitGameCommand();
        quitButton.SetCommand(quitGameCommand);
    }
}