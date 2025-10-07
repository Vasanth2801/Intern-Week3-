using UnityEngine;
using System.Collections;

public class SpeedPowerUp : MonoBehaviour
{
    
    public GameObject healthEffect;
    public float multiplier = 1.6f;
    public float duration = 4;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
           StartCoroutine(PowerupPicked(other));
        }


            
        IEnumerator PowerupPicked(Collider2D Player)
        {
            Instantiate(healthEffect,transform.position,transform.rotation);

            Player.GetComponent<SimplePlayerMovement>().speed += multiplier;

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false; 

            yield return new WaitForSeconds(duration);

            Player.GetComponent <SimplePlayerMovement>().speed -= multiplier;
            Destroy(gameObject);
        }
    }
}
