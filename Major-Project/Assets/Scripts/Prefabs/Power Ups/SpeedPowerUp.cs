using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedUp")]
public class SpeedPowerUp : PowerUpEffect
{
    public float speedIncreaseAmount; 
    public override void Apply(GameObject target)
    {
        target.GetComponent<PLayerController>().movementSpeed += speedIncreaseAmount;
    }
}
