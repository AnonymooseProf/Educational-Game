using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/PointsUp")]
public class PointsPowerUp : PowerUpEffect
{
    public float pointIncreaseAmount;
    public override void Apply(GameObject target)
    {
        target.GetComponentInParent<GameManager>().UpdateScoreCounter(pointIncreaseAmount);
    }
}
