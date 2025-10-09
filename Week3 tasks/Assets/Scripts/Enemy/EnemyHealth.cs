using Unity.Hierarchy;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public static EnemyHealth Instance;
    private SlowMotioneffect slowMotioneffect;
    public int maxHealth = 50;
    public int currentHealth;
  


    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        slowMotioneffect = FindAnyObjectByType<SlowMotioneffect>();
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
        {
            slowMotioneffect.SlowMotion();
            AudioManager.instance.PlayEnemyDeath();
            Destroy(gameObject);
        }
    }
}
