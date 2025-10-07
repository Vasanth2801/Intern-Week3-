using UnityEngine;


[CreateAssetMenu(menuName = "Powerups/healthbuff")]
public class HealthBuff : PowerupEffect
{
    public float amount = 20f;
    public override void Apply(GameObject target)
    {
        //target.GetComponent<PlayerMovement>().health += amount;
    }
}
