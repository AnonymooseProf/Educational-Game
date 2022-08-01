using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Clues/PickClue")]
public class PickClue : ClueEffect
{
    public bool[] clueShown;
    public GameObject[] clues;
    public override void Apply(GameObject target)
    {
        
    }
}