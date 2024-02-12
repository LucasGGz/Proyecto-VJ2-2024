using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameCommand : ICommand
{
     // Método de la interfaz ICommand que ejecuta la acción de salir del juego
    public void Execute()
    {
        Application.Quit();
    }
}