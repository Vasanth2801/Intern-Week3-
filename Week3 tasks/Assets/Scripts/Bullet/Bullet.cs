using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    Rigidbody2D rb;
    public GameObject explosionEffect;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.linearVelocity = transform.right * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enemy Hit");
            Destroy(this.gameObject);
            Instantiate(explosionEffect,transform.position,transform.rotation);
            Destroy(explosionEffect);
            Destroy(other.gameObject);
        }
    }
}