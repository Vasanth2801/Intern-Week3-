using UnityEngine;

public class HealthBoss : MonoBehaviour
{
    public static HealthBoss Instance;
    public int maxHealth = 200;
    public int currentHealth;


    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
