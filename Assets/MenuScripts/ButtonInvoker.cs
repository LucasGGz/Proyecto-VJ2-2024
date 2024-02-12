using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInvoker : MonoBehaviour
{
    private ICommand command;

    // M�todo para establecer un nuevo comando
    public void SetCommand(ICommand newCommand)
    {
        command = newCommand;
    }

    // M�todo que simula la acci�n de presionar un bot�n
    public void PressButton()
    {
        if (command != null)
        {
            command.Execute();
        }
    }
}