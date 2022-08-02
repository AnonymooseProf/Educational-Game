using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Clues/PickClue")]
public class PickClue : ClueEffect
{
    public bool[] clueShown;
    public GameObject[] clues;
    public int clueNumber; 
    public override void Apply(GameObject target)
    {
        foreach (GameObject clue in clues)
        {
            if (clueShown[clueNumber].Equals(false))
            {
                clue.SetActive(true);
                clueShown[clueNumber] = true;
                clueNumber = 0;
            }
            else { clueNumber++; }
        }
    }
}