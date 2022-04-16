using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizes : MonoBehaviour
{
    public GameObject quizOne;
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
