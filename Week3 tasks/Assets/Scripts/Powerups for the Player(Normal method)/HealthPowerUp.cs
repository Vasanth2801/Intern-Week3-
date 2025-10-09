using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    SimplePlayerMovement  player;

    public int amount = 20;


    private void Awake()
    {
        player = GetComponent<SimplePlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            
                player.GetComponent<SimplePlayerMovement>().currentHealth += amount;

                Destroy(gameObject);
        }
    }
}

