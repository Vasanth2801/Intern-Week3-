using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    float moveInputX;
    public bool isFacingRight = true;
    public float jumpForce = 9f;
    private bool isJumping = false;

    public int maxHealth = 100;
    public int  currentHealth;
    public PlayerHealthBar playerHealthBar;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        currentHealth = maxHealth;
        playerHealthBar.SetMaxHealth(maxHealth);
    }

    private void Update()
    {
         moveInputX = Input.GetAxisRaw("Horizontal");

         if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
         {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isJumping = true;
            animator.SetBool("Jump", true);
         }

        Flip();

        if(Input.GetKeyDown(KeyCode.X))
        {
            Takedamage(20);
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInputX * speed,rb.linearVelocity.y);
        animator.SetFloat("Speed", Mathf.Abs(moveInputX));
    }

    public void Flip()
    {
        if(isFacingRight && moveInputX < 0 || !isFacingRight && moveInputX > 0)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;

        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground") && isJumping)
        {
            isJumping = false;
            animator.SetBool("Jump", false);
        }
    }


    public void Takedamage(int damage)
    {
        currentHealth -= damage;
            
        playerHealthBar.SetHealth(currentHealth);
    }
}
