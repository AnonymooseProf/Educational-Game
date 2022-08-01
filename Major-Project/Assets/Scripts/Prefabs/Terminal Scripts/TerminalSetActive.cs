using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalSetActive : MonoBehaviour, Terminals
{
    private bool isOpen = false;
    private Dictionary<string, int> terminals = new Dictionary<string, int>();

    public void Start()
    {
        terminals.Add("terminalOne", 1);
        terminals.Add("terminalTwo", 2);
        terminals.Add("terminalThree", 3);
        terminals.Add("terminalFour", 4);
        terminals.Add("terminalFive", 5);
        terminals.Add("terminalSix", 6);
        terminals.Add("terminalSeven", 7);
    }
    public void OpenTerminal()
    {
        OpenQuizes(gameObject.tag);
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
            OpenQuizes(gameObject.tag);
        }
        else
        {
            FindQuizToClose(gameObject.tag);
        }
    }

    //I've deleted the old function but trust me this is much more sexy
    //This is first material surely :)
    public int FindQuiz(string terminalName)
    {
        
        foreach (KeyValuePair<string, int> i in terminals)
        {
            if (terminalName.Equals(i.Key))
            {
                return(i.Value);
            }       
        }
        return -1;
    }

    public void OpenQuizes(string terminalName)
    {
        Quizes quizes = FindObjectOfType<Quizes>();
        int terminalNumber = FindQuiz(terminalName);
        quizes.OpenQuizes(terminalNumber);
    }

    public void FindQuizToClose(string terminalName)
    {
        Quizes quizes = FindObjectOfType<Quizes>();
        foreach (KeyValuePair<string, int> i in terminals)
        {
            if (terminalName.Equals(i.Key))
            {
                quizes.CloseQuizes(i.Value);
            }
        }
    }
}
