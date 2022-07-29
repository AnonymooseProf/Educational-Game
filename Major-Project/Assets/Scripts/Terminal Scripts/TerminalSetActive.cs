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
        ShinyNewFindQuiz(gameObject.tag);
    }
    public void CloseTerminal()
    {
        ShinyNewFindQuizToClose(gameObject.tag);
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

    //I've deleted the old function but trust me this is much more sexy
    public void ShinyNewFindQuiz(string terminalName)
    {
        Quizes quizes = FindObjectOfType<Quizes>();
        foreach (KeyValuePair<string, int> i in terminals)
        {
            if (terminalName.Equals(i.Key))
            {
                quizes.OpenQuizes(i.Value);
            }       
        }
    }

    public void ShinyNewFindQuizToClose(string terminalName)
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
    /*public void FindQuiz(string quizNumber)
    {
        //I know this could be done better but brain fryed at the mmoment so this is how we roll
        Quizes quizes = FindObjectOfType<Quizes>();
        if (quizNumber.Equals("terminalOne"))
        {
            quizes.OpenQuizes(1);
        }
        else if(quizNumber.Equals("terminalTwo"))
        {
            quizes.OpenQuizes(2);
        }
        else if (quizNumber.Equals("terminalThree"))
        {
            quizes.OpenQuizes(3);
        }
        else if (quizNumber.Equals("terminalFour"))
        {
            quizes.OpenQuizes(4);
        }
        else if (quizNumber.Equals("terminalFive"))
        {
            quizes.OpenQuizes(5);
        }
        else if (quizNumber.Equals("terminalSix"))
        {
            quizes.OpenQuizes(6);
        }
        else if (quizNumber.Equals("terminalSeven"))
        {
            quizes.OpenQuizes(7);
        }

    }

    public void FindQuizToClose(string quizNumber)
    {
        //I figured out and if I have time I'll impliment it, can make array of the terminal names and use a loop to cycle through the check instead of this mess
        //Not very future proof, sorry to who ever may expand on this :)
        Quizes quizes = FindObjectOfType<Quizes>();
        if (quizNumber.Equals("terminalOne"))
        {
            quizes.CloseQuizes(1);
        }
        else if (quizNumber.Equals("terminalTwo"))
        {
            quizes.CloseQuizes(2);
        }
        else if (quizNumber.Equals("terminalThree"))
        {
            quizes.CloseQuizes(3);
        }
        else if (quizNumber.Equals("terminalFour"))
        {
            quizes.CloseQuizes(4);
        }
        else if (quizNumber.Equals("terminalFive"))
        {
            quizes.CloseQuizes(5);
        }
        else if (quizNumber.Equals("terminalSix"))
        {
            quizes.CloseQuizes(6);
        }
        else if (quizNumber.Equals("terminalSeven"))
        {
            quizes.CloseQuizes(7);
        }
    }
    */
}
