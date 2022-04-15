using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalSetActive : MonoBehaviour, Terminals
{
    private bool isOpen = false;
    public GameObject quizOne;
    public void OpenTerminal()
    {
        FindQuiz(gameObject.tag);
    }
    public void CloseTerminal()
    {
        //public void ContinueAfterPause()
        //{
        //    pausePannel.SetActive(false);
        //    Time.timeScale = 1f;
        //    isGamePaused = false;
        //}
    }

    public void ToggleTerminal()
    {
        isOpen = !isOpen;
        if (isOpen)
        {
            OpenTerminal();
        }
        else
        {
            CloseTerminal();
        }
    }

    public void FindQuiz(string quizNumber)
    {
        Quizes quizes = FindObjectOfType<Quizes>();
        if (quizNumber.Equals("terminalOne"))
        {
            quizes.openQuizOne();
        }

    }
}
