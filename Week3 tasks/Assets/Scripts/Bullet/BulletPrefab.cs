using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
   [SerializeField] private float speed = 20f; // Speed of the bullet

   [SerializeField] private Rigidbody2D rb; // Rigidbody2D component for physics

    void FixedUpdate()
    {
        rb.linearVelocity = transform.up * speed; // Move the bullet in the right direction
    }

    // Method to handle collision with the player
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Check if the collided object is the player
        {
            Debug.Log("Bullet hit the player!"); // Log a message for debugging
            Destroy(gameObject); // Destroy the bullet after hitting the player
        }
    }
}
