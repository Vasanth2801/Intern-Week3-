using UnityEngine;

public class RangedEnemy : MonoBehaviour
{
    public float enemySpeed = 5f;    // Speed of the enemy
    public Transform target;            // Target for the enemy to follow
    public float rotationSpeed = 0.0025f;       // Speed of rotation towards the target

    private Rigidbody2D rb;      // Rigidbody2D component for physics

    public float distanceToShoot = 5f;    // Distance to shoot the player
    public float diatnceToStop = 2f;     // Distance to stop the enemy from moving

    public float fireRate; // Rate of fire for the enemy
    public float timer = 0;   // Timer to keep track of fire rate

    public Transform firePoint;      // Point from where the bullet will be fired
    public GameObject BulletPrefab;  // Bullet prefab to instantiate when shooting

    //Awake is called before the first frame is called 
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();       // Get the Rigidbody2D component
        timer = fireRate;       // Initialize the timer with fire rate
    }

    // Update is called once per frame
    private void  Update()
    {
        if (target == null)          // If there is no target, find the player
        {
            GetTarget();       // Find the player
        }
        else
        {
            RotateTowardsTarget();         // Rotate towards the target
        }

        if(Vector2.Distance(transform.position, target.position) <= distanceToShoot)
        {
            Shoot();
        }
    }


    void Shoot()
    {
        if(timer<=0)
        {
            Instantiate(BulletPrefab,firePoint.position, firePoint.rotation); // Instantiate the bullet at the fire point
            timer = fireRate;       // Reset the timer
        }
        else
        {
            timer -= Time.deltaTime;    // Decrease the timer
        }
    }


    // It is used for physics interval 
    void FixedUpdate()
    {
        if(Vector2.Distance(transform.position, target.position) >= distanceToShoot)
        {
            rb.linearVelocity = transform.up * enemySpeed * Time.fixedDeltaTime;          // Move the enemy forward
        }
        else
        {
            rb.linearVelocity = Vector2.zero;      // Stop the enemy from moving
        }
           
    }

    // method to find the player
    void GetTarget()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;          // Find the player by tag
    }

    // Method to rotate the enemy towards the target
    void RotateTowardsTarget()
    {
        Vector2 direction = target.position - transform.position;   // Get the direction to the target
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f; // Calculate the angle to the target 
        Quaternion q = Quaternion.Euler(new Vector3(0, 0, angle));             // Create a quaternion from the angle
        transform.localRotation = Quaternion.Slerp(transform.localRotation, q, rotationSpeed); // Rotate the enemy towards the target
    }
}
