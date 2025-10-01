using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public BossHealthBar bossHealthBar;

    void Start()
    {
        currentHealth = maxHealth;
        bossHealthBar.SetHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        bossHealthBar.SetHealth(currentHealth);
    }
}