using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public PowerupEffect speedupEffect;
    public GameObject speedEffect;
    private float timer =4;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            speedupEffect.Apply(other.gameObject);
            Instantiate(speedupEffect,transform.position, Quaternion.identity);
            Destroy(this.gameObject);

            if(timer > 0)
            {
                timer -= Time.deltaTime;

                if(timer == 0)
                {
                    speedupEffect.Remove(other.gameObject);
                }
            }
        }
    }
}