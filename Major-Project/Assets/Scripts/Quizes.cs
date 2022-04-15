using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizes : MonoBehaviour
{
    public GameObject quizOne;
    public void openQuizOne()
    {
        quizOne.SetActive(true);
        Time.timeScale = 0f;
    }
    
}
