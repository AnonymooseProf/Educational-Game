using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private int HighScore = 50;
    private int MediumScore = 25;
    private int LowScore = 10;
    public Text scoreText;

    public void Start()
    {
        
        UpdateScoreCounter();
    }
    public void UpdateScoreCounter()
    {
        scoreText.text = "Score: " + PlayerInfo.playerScore;
    }

    public void EndGameTimerScoreModifier(float playerTime)
    {
        int scoreModifier;
        if(playerTime < 61)
        {
            scoreModifier = HighScore;
        }
        else if(playerTime < 120 && playerTime > 60)
        {
            scoreModifier = MediumScore;
        }
        else
        {
            scoreModifier = LowScore;
        }
        PlayerInfo.playerScore += scoreModifier;
    }
}
