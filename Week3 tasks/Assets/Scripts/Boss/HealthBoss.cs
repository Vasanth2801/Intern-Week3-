using UnityEngine;

public class HealthBoss : MonoBehaviour
{
    public static HealthBoss Instance;     // Singleton Pattern implementation  
    public int maxHealth = 200;            // Maxhealth for the boss 
    public int currentHealth;              // current health for the boss
    SlowMotioneffect slowMotioneffect;     // reference for theslowmotion effect we have created 

    // called before the first frame of the game
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;                  // Telling this is the singleton 
            DontDestroyOnLoad(gameObject);      //Dont destroy on load 
        }
        else
        {
            Destroy(gameObject);             //Destroying the gameObject 
        } 
    }

    //First frame of the game 
    private void Start()
    {
        currentHealth = maxHealth;                                       //Setting the current health to the maxhealth 
        slowMotioneffect = FindAnyObjectByType<SlowMotioneffect>();     // finding the slowmotion effect script we have created 
    }


    //method for taking damage 
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;       // the damage reducing the current health 
       

        if(currentHealth <= 0)
        {
            AudioManager.instance.PlayBossDeath();       //Playing the soundeffect for the boss 
            Destroy(gameObject);                          //Destroying the gameobject of the boss 
            slowMotioneffect.SlowMotion();               // telling the slowmotion effect to play 
        }
    }

    // Checking for whether is there any collsiosns
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))     // if gameobject with bullet tag collides
        {
            TakeDamage(10);                            // Taking the damage 
            ScoreManager.instance.AddScore(25);         //Increasing the score of the game 
        }
    }
}
