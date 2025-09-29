 using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    public Transform target;     // Target for enemy to follow
    public float speed = 2f;     // Speed of the enemy moving 
    public float nextWayPointDistance = 0.3f; // Distance to the next waypoint to consider it reached

    Path path;                      // Current path to the target
    int currentWayPoint = 0;            // Current waypoint in the path
    bool reachedEndOfPath = false;       // Check if the enemy has reached the end of the path

    Seeker seeker;           // Seeker component for pathfinding
    Rigidbody2D rb;          // rigidbody component for physics

    private PlayerMovement playerMovement; // Reference to the PlayerMovement script
    public float KnockBackForce = 10f; // Force of the knockback


    private void Start()
    {
        seeker = GetComponent<Seeker>();  // Get the Seeker component
        rb = GetComponent<Rigidbody2D>();   // Get the Rigidbody2D component
        playerMovement = FindObjectOfType<PlayerMovement>(); // Find the PlayerMovement script in the scene

        InvokeRepeating("UpdatePath", 0f, 0.5f); // Update the path every 0.5 seconds
    }

    private void UpdatePath()
    {
        if(seeker.IsDone())
        {
            seeker.StartPath(rb.position, target.position, OnPathComplete);    // Start calculating the path to the target
        }
    }

    // This method is used to check the path and move the enemy 
    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWayPoint = 0;
        }
    }

    void FixedUpdate()
    {
        if (path == null)
        {
            return; // No path to follow    
        }

        if (currentWayPoint >= path.vectorPath.Count)
        {
            reachedEndOfPath = true;
            return;
        }
        else
        {
            reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWayPoint] - rb.position).normalized; // Get the direction to the next waypoint
        Vector2 force = direction * speed * Time.deltaTime;    //Calcualte the force to apply to the enemy
        rb.AddForce(force);    // Apply the force to the enemy

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWayPoint]); // Calculate the distance to the next waypoint

        if (distance < nextWayPointDistance)
        {
            currentWayPoint++; // Move to the next waypoint
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                playerMovement.Knockback(transform,KnockBackForce); // Call the Knockback method from the PlayerMovement script
            }
        }
    }
}
