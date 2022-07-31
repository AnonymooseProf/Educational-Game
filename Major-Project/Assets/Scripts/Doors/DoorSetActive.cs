using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSetActive : MonoBehaviour, Doors
{
    public Quizes quizes;
    public GameObject notFinishedScreen;
    public GameManager gameManager;
    public PLayerController player;

    public void ExitDoorActivate()
    {
        bool isComplete = ExitDoorCheck();
        if (isComplete)
        {
            SceneManager.LoadScene("End Screen");
        }
        else
        {
            NotFinishedScreen();
        }
    }

    public void NotFinishedScreen()
    {
        notFinishedScreen.SetActive(true);
        player.TogglePlayerLight(false);
        Time.timeScale = 0f;
        gameManager.isGamePaused = true;
    }
    public bool ExitDoorCheck()
    {
        foreach (bool i in quizes.isComplete)
        {
            if (i.Equals(false)) 
            {
                return (false);
            }
              
        }
        return (true);
    }
}
