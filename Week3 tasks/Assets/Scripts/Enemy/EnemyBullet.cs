using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 7f;
    Rigidbody2D rb;
    public SimplePlayerMovement simplePlayerMovement;


    public float lifeOfBullet = 4f;
    float timer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        timer = lifeOfBullet;
        if( rb != null )
        {
            rb.linearVelocity = transform.up * speed;
        }

    }


    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    
}
