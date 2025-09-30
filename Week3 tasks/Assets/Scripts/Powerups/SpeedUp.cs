using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public PowerupEffect speedupEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            speedupEffect.Apply(other.gameObject);
            Destroy(gameObject);
        }
    }
}
