using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    Rigidbody2D rb;
    PlayerController playerController;
    Vector2 movement;
    public float knockbackForce = 10f; // Force of the knockback

    private bool isKnockedback = false; // Flag to check if the player is currently being knocked back

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerController = new PlayerController();

        MovementCalling();

    }


    void MovementCalling()
    {
        playerController.Player.Move.performed += ctx => movement = ctx.ReadValue<Vector2>();
        playerController.Player.Move.canceled += ctx => movement = Vector2.zero;
    }

    private void OnEnable()
    {
        playerController.Player.Enable();
    }

    private void OnDisable()
    {
        playerController.Player.Disable();
    }

    private void FixedUpdate()
    {
        if (isKnockedback)
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }                      
        
    }


    public void Knockback(Transform enemy, float force) // Knockback function to be called when the player is hit
    {
        isKnockedback = true; // Set the flag to true
        Vector2 knockbackDirection = (transform.position - enemy.position).normalized; // Calculate the direction of the knockback
        rb.linearVelocity = knockbackDirection * knockbackForce; // Apply the knockback force   
    }
}

