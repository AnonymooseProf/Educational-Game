using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollide : MonoBehaviour
{
    public CluePicker cluePicker;
    private void nCollisionEnter2D(Collision2D collision)
    {
        cluePicker.pickClueToDisplay();
    }
}
