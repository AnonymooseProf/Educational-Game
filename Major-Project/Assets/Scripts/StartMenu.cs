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

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
}
