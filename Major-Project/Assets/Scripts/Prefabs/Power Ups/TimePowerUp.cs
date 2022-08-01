using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/TimeDown")]
public class TimePowerUp : PowerUpEffect
{
    public float timeDecreaseAmount;
    public override void Apply(GameObject target)
    {
        target.GetComponentInParent<GameManager>().UpdateTimer(timeDecreaseAmount);
    }
}
