using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizes : MonoBehaviour
{
    public GameObject quizOne;
    public GameObject playerLight;
    public GameObject correctAnswer;
    public GameObject incorrectAnswer;
    private GameObject currentQuiz;
    private GameObject playerAnswer;
    public void openQuizOne()
    {
        currentQuiz = quizOne;
        quizOne.SetActive(true);
        Time.timeScale = 0f;
        playerLight.SetActive(false);
    }
    
    public void closeQuizOne()
    {
        quizOne.SetActive(false);
        Time.timeScale = 1f;
        playerLight.SetActive(true);
    }

    public void CorrectAnswer()
    {
        currentQuiz.SetActive(false);
        correctAnswer.SetActive(true);
        playerAnswer = correctAnswer;
    }

    public void IncorrectAnswer()
    {
        currentQuiz.SetActive(false);
        incorrectAnswer.SetActive(true);
        playerAnswer = incorrectAnswer;
    }

    public void ContinueAfterAnswer()
    {
        playerAnswer.SetActive(false);
        Time.timeScale = 1f;
        playerLight.SetActive(true);
    }

}
