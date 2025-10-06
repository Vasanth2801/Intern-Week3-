using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.AddScore(25);
            Debug.Log("CoinPickedUp");
            Destroy(gameObject);
        }
    }
}