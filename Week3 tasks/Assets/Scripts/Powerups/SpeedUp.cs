using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public PowerupEffect speedupEffect;
    public GameObject speedEffect;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            speedupEffect.Apply(other.gameObject);
            Instantiate(speedupEffect,transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}