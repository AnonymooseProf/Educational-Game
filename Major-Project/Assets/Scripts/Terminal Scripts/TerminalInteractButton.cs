using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminalInteractButton : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRadius = 2f;
            Collider2D[] collider2DArray = Physics2D.OverlapCircleAll(playerTransform.position, interactRadius);
            foreach (Collider2D collider2D in collider2DArray)
            {
                Terminals terminals = collider2D.GetComponent<Terminals>();
                if (terminals != null)
                {
                    terminals.ToggleTerminal();
                }
            }
        }
    }
}
