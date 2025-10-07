using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    float moveInputX;
    public bool isFacingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
         moveInputX = Input.GetAxisRaw("Horizontal");

        Flip();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInputX * speed,rb.linearVelocity.y);
        animator.SetFloat("Speed", Mathf.Abs(moveInputX));
    }

    void Flip()
    {
        if(isFacingRight && moveInputX < 0 || !isFacingRight && moveInputX > 0)
        {
            isFacingRight = !isFacingRight;

            transform.Rotate(0f, 180f, 0f);
        }
    }    
}
