using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public GameManager gameManager;
    public void MainScene()
    {
        SceneManager.LoadScene("Main");
    }
}
