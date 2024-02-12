using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInvoker : MonoBehaviour
{
    private ICommand command;

    // Método para establecer un nuevo comando
    public void SetCommand(ICommand newCommand)
    {
        command = newCommand;
    }

    // Método que simula la acción de presionar un botón
    public void PressButton()
    {
        if (command != null)
        {
            command.Execute();
        }
    }
}