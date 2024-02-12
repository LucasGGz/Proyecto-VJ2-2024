using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneCommand : ICommand
{
   private string sceneName;

   // Constructor que recibe el nombre de la escena como parámetro
    public ChangeSceneCommand(string sceneName)
    {
        this.sceneName = sceneName;
    }

    //Metodo que ejecuta el cambio de escena
    public void Execute()
    {
        SceneManager.LoadScene(sceneName);
    }
}