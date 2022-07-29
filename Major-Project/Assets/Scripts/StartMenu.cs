using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT PUSHED");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
}
