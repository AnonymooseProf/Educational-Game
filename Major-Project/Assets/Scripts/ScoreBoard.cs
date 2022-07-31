using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

    public Text scoreText;

    public void Start()
    {
        Debug.Log(PlayerInfo.playerScore);
        UpdateScoreCounter();
    }
    public void UpdateScoreCounter()
    {
        scoreText.text = "Score: " + PlayerInfo.playerScore;
    }
}
