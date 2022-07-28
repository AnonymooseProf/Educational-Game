using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizes : MonoBehaviour
{
    public GameObject quizOne;
    public GameObject quizTwo;
    public GameObject correctAnswer;
    public GameObject incorrectAnswer;
    private GameObject currentQuiz;
    private GameObject playerAnswer;
    public PLayerController player;
    public GameManager manager;
    public void openQuizOne()
    {
        currentQuiz = quizOne;
        quizOne.SetActive(true);
        Time.timeScale = 0f;
        player.TogglePlayerLight(false);
    }

    public void OpenQuizes(int quizNumber)
    {
        Time.timeScale = 0f;
        player.TogglePlayerLight(false);
        switch (quizNumber)
        {
            case 1:
                currentQuiz = quizOne;
                quizOne.SetActive(true);
                break;
            case 2:
                currentQuiz = quizTwo;
                quizTwo.SetActive(true);
                break;
        }

    }

    public void CloseQuizes(int quizNumber)
    {
        Time.timeScale = 1f;
        player.TogglePlayerLight(true);
        switch (quizNumber)
        {
            case 1:
                quizOne.SetActive(false);
                break;
            case 2:
                quizTwo.SetActive(false);
                break;
        }

    }

    public void closeQuizOne()
    {
        quizOne.SetActive(false);
        Time.timeScale = 1f;
        player.TogglePlayerLight(true);
    }

    public void CorrectAnswer()
    {
        currentQuiz.SetActive(false);
        correctAnswer.SetActive(true);
        playerAnswer = correctAnswer;
        manager.UpdateScoreCounter(20);
    }

    public void IncorrectAnswer()
    {
        currentQuiz.SetActive(false);
        incorrectAnswer.SetActive(true);
        playerAnswer = incorrectAnswer;
        manager.UpdateScoreCounter(-10);
    }

    public void ContinueAfterAnswer()
    {
        playerAnswer.SetActive(false);
        Time.timeScale = 1f;
        player.TogglePlayerLight(true);
    }

}
