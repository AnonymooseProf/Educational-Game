using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public bool isGamePaused = false;
    public Text scoreText;
    public PLayerController player;
    public GameObject nextLevelPannel;
    public GameObject gameOverPannel;
    public GameObject pausePannel;
    public GameObject[] Levels;
    public GameObject ResetScreen, End;
    public GameObject startGameScreen;
    public float playerScore = 0;
    int currentLevel;
    void Start()
    {
        StartGame();
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
                player.TogglePlayerLight(false);
            }
        }
        
    }

    public void UpdateScoreCounter(float newScore)
    {
        playerScore += newScore;
        scoreText.text = "Score: " + playerScore;
    }

    public void StartGame()
    {
        player.TogglePlayerLight(false);
        scoreText.text = "Score: " + playerScore;
        Time.timeScale = 0f;
        startGameScreen.SetActive(true);
    }
    public void StartGameTimer()
    {
        startGameScreen.SetActive(false);
        Time.timeScale = 1f;
        player.TogglePlayerLight(true);
        TimerController.instance.BeginTimer();
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
        player.TogglePlayerLight(true);
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
}
