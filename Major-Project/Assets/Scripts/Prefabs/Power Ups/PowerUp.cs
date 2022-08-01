using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerUpEffect powerUpEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (gameObject.tag.Equals("Player"))
        //{
            Debug.Log("Power UP!");
            Destroy(gameObject);
            powerUpEffect.Apply(collision.gameObject);
        //}
    }
}
