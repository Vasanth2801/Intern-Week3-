using UnityEngine;

[CreateAssetMenu(menuName = "Powerups/SpeedBuff")]
public class SpeedBuff : PowerupEffect
{
    public float amount = 15f;

    public override void Apply(GameObject target)
    {
        //target.GetComponent<PlayerMovement>().moveSpeed += amount;
    }
}
