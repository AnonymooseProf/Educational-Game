using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowClue : MonoBehaviour
{
    public GameObject clue;
    public PLayerController player;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        clue.SetActive(true);
        player.TogglePlayerLight(false);
        Time.timeScale = 0f;
    }

    public void HideClue()
    {
        clue.SetActive(false);
        player.TogglePlayerLight(true);
        Time.timeScale = 1f;
    }
}
