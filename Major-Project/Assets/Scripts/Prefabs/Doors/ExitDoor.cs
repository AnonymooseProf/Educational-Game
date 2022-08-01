using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoor : MonoBehaviour
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
                Doors doors = collider2D.GetComponent<Doors>();
                if (doors != null)
                {
                    //for future if more doors other than the exit are added, add door check method
                    doors.ExitDoorActivate();
                }
            }
        }
    }
}
