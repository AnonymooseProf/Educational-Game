using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

[CreateAssetMenu(menuName = "Powerups/FOVUp")]
public class FOVPowerUp : PowerUpEffect
{
    public float innerAndOutterIncrease;
    public float radiusIncrease;
    public override void Apply(GameObject target)
    {
        target.GetComponentInChildren<Light2D>().pointLightOuterRadius += radiusIncrease;
        target.GetComponentInChildren<Light2D>().pointLightOuterAngle += innerAndOutterIncrease;
        target.GetComponentInChildren<Light2D>().pointLightInnerAngle += innerAndOutterIncrease;
    }
}
