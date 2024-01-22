using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Invoker
public class ButtonInvoker : MonoBehaviour
{
    private ICommand command;

    public void SetCommand(ICommand newCommand)
    {
        command = newCommand;
    }

    public void PressButton()
    {
        if (command != null)
        {
            command.Execute();
        }
    }
}