using UnityEngine;

public class SimplePlayerMovement : MonoBehaviour
{
    [Header("PlayerMovement Settings")]
    public float speed = 5f;            //Speed of the Player
    public float jumpForce = 9f;       //Jumping force of the player
    float moveInputX;                   //Movement imput for the player 

    [Header("References")]
    private Rigidbody2D rb;               //Refrence for the rigidbody
    private Animator animator;            //Reference for the animator 

    [Header("Bool for the players")]
    public bool isFacingRight = true;       //bool to check whether the player is in left or right direction
    private bool isJumping = false;         //bool for checking the player whether is he jumping or not 

    [Header("PlayerHealthSettings")]
    public int maxHealth = 100;              // max health of the player 
    public int  currentHealth;               // current health for storing
    public PlayerHealthBar playerHealthBar;      //Reference to the player healthbar we ahve created 

    // Awake is Called before the first update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();             //Reference to the rigidbody2D
        animator = GetComponent<Animator>();          //Reference to the player animator 
    }


    //Start is Called for the first update of the Game
    private void Start()
    {
        currentHealth = maxHealth;                          //Setting the health of the player
        playerHealthBar.SetMaxHealth(maxHealth);            //Showing the health of the player in UI 
    }


    //Update is called for once per every frame 
    private void Update()
    {
         moveInputX = Input.GetAxisRaw("Horizontal");      // Getting the horizontal  axis value 


        //Jumping Logic 
         if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
         {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);     //telling rb to add force in y axis 
            isJumping = true;                       //bool for jumping
            animator.SetBool("Jump", true);        //Animation for jumping
         }

        Flip();                    //Flipping the player according to the movement 
    }


    //Used for physics related works 
    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveInputX * speed,rb.linearVelocity.y);    // Telling the player to move in x direction
        animator.SetFloat("Speed", Mathf.Abs(moveInputX));                         // Playing the Run Animation 
    }


    // Flipping logic for the player to turn 
    public void Flip()
    {
        if(isFacingRight && moveInputX < 0 || !isFacingRight && moveInputX > 0)
        {
            isFacingRight = !isFacingRight;                   
            Vector3 localScale = transform.localScale;              // declearing a variable for the localScale 
            localScale.x *= -1;                                     //Changing the direction in x axis alone 
            transform.localScale = localScale;                      //setting the localscale to the declared variable 

        }
    }

    // Check whether is there any collision with other objects
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground") && isJumping)      // checking for not double jumping in air
        {
            isJumping = false;                                       //setting the bool to false
            animator.SetBool("Jump", false);                           // Animatior to false
        }

        
    }


    //Method for the player to take damage
    public void Takedamage(int damage)
    {
        currentHealth -= damage;                      //the damage done is  reducing the current health we are having
            
        playerHealthBar.SetHealth(currentHealth);         // showing the current health in UI 

        if(currentHealth <= 0)                             //if the health falls less than or equal to zero
        {
            AudioManager.instance.PlayDeathSound();          //Playing the Deathsound of the player from the audio manager reference 
            Destroy(this.gameObject);                        // Destroying the player gameobject 
            UIManager.instance.GameOver();                   //Showing the gameover panel
        }
    }


    // Checking for the physics collision
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))            //if the gameobject with tag enemy bullet hits
        {

            Debug.Log("PlayerHit");                    //Checking in console whether it is colliding
            Takedamage(10);                            //Taking the damage and reducing the player health
            Destroy(other.gameObject);                //Destroying the bullet of the enemy when collided 
        }
    }

}
