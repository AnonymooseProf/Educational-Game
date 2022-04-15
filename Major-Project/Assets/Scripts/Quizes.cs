using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quizes : MonoBehaviour
{
    public GameObject quizOne;
    public GameObject playerLight;
    public void openQuizOne()
    {
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

}
