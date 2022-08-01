using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clues : MonoBehaviour
{
    public ClueEffect clueEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (gameObject.tag.Equals("Player"))
        //{
        Debug.Log("Clue");
        Destroy(gameObject);
        clueEffect.Apply(collision.gameObject);
        //}
    }
}
