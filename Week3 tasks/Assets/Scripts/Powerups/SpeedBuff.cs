using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedBuff")]
public class SpeedBuff : PowerupEffect
{
    public float amount = 2f;

    public override void Apply(GameObject target)
    {
        target.GetComponent<SimplePlayerMovement>().speed += amount;
    }

    public override void Remove(GameObject target)
    {
        target.GetComponent <SimplePlayerMovement>().speed -= amount;
    }
}
