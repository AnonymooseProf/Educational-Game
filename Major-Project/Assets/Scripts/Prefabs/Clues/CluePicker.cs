using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CluePicker : MonoBehaviour
{
    public bool[] clueShown;
    public GameObject[] levelOneClues;
    
    public void pickClueToDisplay()
    {
        Debug.Log("I've Picked a clue");
    }
}
