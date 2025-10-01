using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public PowerupEffect powerupEffect;
    public GameObject healthEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            powerupEffect.Apply(other.gameObject);
            Instantiate(healthEffect,transform.position,Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
