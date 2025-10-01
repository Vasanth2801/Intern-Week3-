using UnityEngine;

public class FireBall : MonoBehaviour
{
    public GameObject explosionEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit by the fire ball and health is down");
            Destroy(gameObject);
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }
    }
}
