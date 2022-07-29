using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

[CreateAssetMenu(menuName = "ScreenInfo/PlayerInfo")]
public class PlayerInfo : ScriptableObject
{
    public float playerScore;
    public float playerTime;
    public string playerName;
}
