using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalSetActive : MonoBehaviour, Terminals
{
    private bool isOpen = false;

    public void OpenTerminal()
    {
        FindQuiz(gameObject.tag);
    }
    public void CloseTerminal()
    {
        FindQuizToClose(gameObject.tag);
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
            quizes.OpenQuizes(1);
        }
        else if(quizNumber.Equals("terminalTwo"))
        {
            quizes.OpenQuizes(2);
        }

    }

    public void FindQuizToClose(string quizNumber)
    {
        Quizes quizes = FindObjectOfType<Quizes>();
        if (quizNumber.Equals("terminalOne"))
        {
            quizes.CloseQuizes(1);
        }
        else if (quizNumber.Equals("terminalTwo"))
        {
            quizes.CloseQuizes(2);
        }

    }
}
