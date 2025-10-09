using UnityEngine;
using System.Collections;

public class SpeedPowerUp : MonoBehaviour
{
   
    public float multiplier = 50f;
    public float duration = 4;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
           StartCoroutine(PowerupPicked(other));
        }


            
        IEnumerator PowerupPicked(Collider2D Player)
        {
         

            Player.GetComponent<SimplePlayerMovement>().speed += multiplier;

            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false; 

            yield return new WaitForSeconds(duration);

            Player.GetComponent <SimplePlayerMovement>().speed -= multiplier;
            Destroy(gameObject);
        }
    }
}
