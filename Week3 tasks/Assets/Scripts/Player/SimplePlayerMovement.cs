using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
   public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;
    float moveInputX;
    float moveInputY;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
         moveInputX = Input.GetAxisRaw("Horizontal");
         moveInputY = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInputX * speed,moveInputY * speed);
    }
}
