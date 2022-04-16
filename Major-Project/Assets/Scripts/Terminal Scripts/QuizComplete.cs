using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizComplete : MonoBehaviour
{
    public bool quizOneComplete;

    public void QuizOneDone(bool complete)
    {
        if (complete)
        {
            quizOneComplete = true;
        }
    }
}
