using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    Rigidbody2D rb;
    PlayerController playerController;
    Vector2 movement;


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
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
