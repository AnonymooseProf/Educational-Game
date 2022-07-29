using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizes : MonoBehaviour
{
    public GameObject[] allQuizes;
    public GameObject correctAnswer;
    public GameObject incorrectAnswer;
    private GameObject currentQuiz;
    private GameObject playerAnswer;
    public PLayerController player;
    public GameManager manager;
    
    public void OpenQuizes(int quizNumber)
    {
        Time.timeScale = 0f;
        player.TogglePlayerLight(false);
        //to be improved with loop
        switch (quizNumber)
        {
            case 1:
                currentQuiz = allQuizes[quizNumber-=1];
                allQuizes[0].SetActive(true);
                break;
            case 2:
                currentQuiz = allQuizes[quizNumber -= 1];
                allQuizes[1].SetActive(true);
                break;
            case 3:
                currentQuiz = allQuizes[quizNumber -= 1];
                allQuizes[2].SetActive(true);
                break;
            case 4:
                currentQuiz = allQuizes[quizNumber -= 1];
                allQuizes[3].SetActive(true);
                break;
            case 5:
                currentQuiz = allQuizes[quizNumber -= 1];
                allQuizes[4].SetActive(true);
                break;
            case 6:
                currentQuiz = allQuizes[quizNumber -= 1];
                allQuizes[5].SetActive(true);
                break;
            case 7:
                currentQuiz = allQuizes[quizNumber -= 1];
                allQuizes[6].SetActive(true);
                break;
        }

    }

    public void CloseQuizes(int quizNumber)
    {
        Time.timeScale = 1f;
        player.TogglePlayerLight(true);
        //to be improved with loop
        switch (quizNumber)
        {
            case 1:
                allQuizes[0].SetActive(false);
                break;
            case 2:
                allQuizes[1].SetActive(false);
                break;
            case 3:
                allQuizes[0].SetActive(false);
                break;
            case 4:
                allQuizes[1].SetActive(false);
                break;
            case 5:
                allQuizes[0].SetActive(false);
                break;
            case 6:
                allQuizes[1].SetActive(false);
                break;
            case 7:
                allQuizes[0].SetActive(false);
                break;  
        }

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
