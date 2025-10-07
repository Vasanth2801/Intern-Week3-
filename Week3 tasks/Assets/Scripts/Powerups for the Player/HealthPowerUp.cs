using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public GameObject healthEffect;

    public float amount = 20f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Instantiate(healthEffect,transform.position,transform.rotation);

            // reference to the player health 

            Destroy(gameObject);
        }
    }
}

