using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameCommand : ICommand
{
    public void Execute()
    {
        Application.Quit();
    }
}