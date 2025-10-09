using Unity.Cinemachine;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody2D rb;
   

    public float lifeofBullet = 7f;
    private float lifeTimer;
    


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    private void OnEnable()
    {
        lifeTimer = lifeofBullet;
        if(rb != null)
        {
            rb.linearVelocity = transform.right * speed;
        }
       
    }

    private void Update()
    {
        lifeTimer -= Time.deltaTime;
        if(lifeTimer <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Hit");
            EnemyHealth.Instance.TakeDamage(5);
            ScoreManager.instance.AddScore(10);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}

