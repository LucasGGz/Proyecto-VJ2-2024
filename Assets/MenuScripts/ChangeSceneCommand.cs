using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

// Concrete Command
public class ChangeSceneCommand : ICommand
{
   private string sceneName;

    public ChangeSceneCommand(string sceneName)
    {
        this.sceneName = sceneName;
    }

    public void Execute()
    {
        SceneManager.LoadScene(sceneName);
    }
}