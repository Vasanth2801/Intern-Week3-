using Unity.Cinemachine;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject player;       

    public bool isFlipped = false;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1;

        if (transform.position.x > player.transform.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0, 180, 0);
            isFlipped = false;
        }
        else if (transform.position.x < player.transform.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0, 180, 0);
            isFlipped = true;
        }
    }

    
}
