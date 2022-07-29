using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizes : MonoBehaviour
{
    public GameObject[] allQuizes;
    public bool[] isComplete;
    public GameObject correctAnswer;
    public GameObject incorrectAnswer;
    private GameObject currentQuiz;
    private GameObject playerAnswer;
    public PLayerController player;
    public GameManager manager;
    private Dictionary<string, int> quizes = new Dictionary<string, int>();

    public void Start()
    {
        quizes.Add("quizOne", 1);
        quizes.Add("quizTwo", 2);
        quizes.Add("quizThree", 3);
        quizes.Add("quizFour", 4);
        quizes.Add("quizFive", 5);
        quizes.Add("quizSix", 6);
        quizes.Add("quizSeven", 7);
    }

    public void OpenQuizes(int quizNumber)
    {
        if (!isComplete[quizNumber])
        {
            Time.timeScale = 0f;
            player.TogglePlayerLight(false);
            //to be improved with loop
            switch (quizNumber)
            {
                case 1:
                    currentQuiz = allQuizes[quizNumber -= 1];
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
                allQuizes[2].SetActive(false);
                break;
            case 4:
                allQuizes[3].SetActive(false);
                break;
            case 5:
                allQuizes[4].SetActive(false);
                break;
            case 6:
                allQuizes[5].SetActive(false);
                break;
            case 7:
                allQuizes[6].SetActive(false);
                break;  
        }

    }

    public void SetQuizComplete(string quizName)
    {
        int quizNumber = QuizToInt(quizName);
        isComplete[quizNumber] = true;
    }

    private int QuizToInt(string quizName)
    {
        foreach (KeyValuePair<string, int> i in quizes)
        {
            if (quizName.Equals(i.Key))
            {
                return (i.Value);
            }
        }
        return -1;
    }

    public void CorrectAnswer()
    {
        currentQuiz.SetActive(false);
        correctAnswer.SetActive(true);
        playerAnswer = correctAnswer;
        manager.UpdateScoreCounter(20);
        SetQuizComplete(currentQuiz.tag);
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
