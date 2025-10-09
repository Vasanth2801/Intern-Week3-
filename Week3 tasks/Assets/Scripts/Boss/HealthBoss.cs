using UnityEngine;

public class HealthBoss : MonoBehaviour
{
    public static HealthBoss Instance;
    public int maxHealth = 200;
    public int currentHealth;
    SlowMotioneffect slowMotioneffect;

    private void Start()
    {
        currentHealth = maxHealth;
        slowMotioneffect = FindAnyObjectByType<SlowMotioneffect>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
       

        if(currentHealth <= 0)
        {
            AudioManager.instance.PlayBossDeath();
            Destroy(gameObject);
            slowMotioneffect.SlowMotion();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage(10);
            ScoreManager.instance.AddScore(25);
        }
    }
}
