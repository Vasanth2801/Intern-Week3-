using UnityEngine;

public abstract class PowerupEffect :  ScriptableObject
{
    public abstract void Apply(GameObject target);

    public abstract void Remove(GameObject target);
}
