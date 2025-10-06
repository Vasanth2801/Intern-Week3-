using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public  float moveSpeed = 5f;
    Rigidbody2D rb;
    PlayerController playerController;
    Vector2 movement;
    public float knockbackForce = 10f; // Force of the knockback
    public float health = 100;
    [SerializeField] private float maxHealth;
    [SerializeField] private Image healthImage;
    private Animator animator;

    private bool isKnockedback = false; // Flag to check if the player is currently being knocked back

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        playerController = new PlayerController();
        animator = GetComponent<Animator>();
        maxHealth = health;
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

    void Update()
    {
        healthImage.fillAmount = Mathf.Clamp(health/maxHealth, 0, 1);
    }

    private void FixedUpdate()
    {
        if (isKnockedback == false)
        {
           rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
        }
        else 
        {
            return;
        }
    }


    public void Knockback(Transform enemy, float force) // Knockback function to be called when the player is hit
    {
        isKnockedback = true; // Set the flag to true
        Vector2 knockbackDirection = (transform.position - enemy.position).normalized; // Calculate the direction of the knockback
        rb.linearVelocity = knockbackDirection * knockbackForce; // Apply the knockback force   
    }
}

