using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameCommand : ICommand
{
     // M�todo de la interfaz ICommand que ejecuta la acci�n de salir del juego
    public void Execute()
    {
        Application.Quit();
    }
}