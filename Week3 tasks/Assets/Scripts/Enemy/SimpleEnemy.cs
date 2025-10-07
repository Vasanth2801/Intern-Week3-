using Unity.VisualScripting;
using UnityEngine;

public class SimpleEnemy : MonoBehaviour
{
    //PlayerMovement playerMovement;
    [SerializeField] private float damage = 5f;

    void Start()
    {
        //playerMovement = FindObjectOfType<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //playerMovement.health -= damage;
        }
    }
}
