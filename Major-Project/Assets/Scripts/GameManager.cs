using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public bool isGamePaused = false;
    public GameObject nextLevelPannel;
    public GameObject gameOverPannel;
    public GameObject pausePannel;
    public GameObject[] Levels;
    public GameObject ResetScreen, End;
    int currentLevel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                ContinueAfterPause();
            }
            else
            {
                PauseGame();
            }
        }
        
    }

    public void PauseGame()
    {
        pausePannel.SetActive(true);
        Time.timeScale = 0f;
        isGamePaused = true;
    }
    public void ContinueAfterPause()
    {
        pausePannel.SetActive(false);
        Time.timeScale = 1f;
        isGamePaused = false;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Main Menu");
    }

    void GameOver()
    {
        gameOver = true;
        gameOverPannel.SetActive(true);
    }


    public void wrongAnswer()
    {
        ResetScreen.SetActive(true);
    }

    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void correctAnswer()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
        }
    }
}
