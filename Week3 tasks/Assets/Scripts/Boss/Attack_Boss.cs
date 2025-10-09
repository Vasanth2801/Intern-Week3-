using UnityEngine;

public class Attack_Boss : MonoBehaviour
{
    public int attackDamage = 20;
    public int RageDamage = 40;
    public GameObject fireBall;
    public Vector3 attackOffset;
    public float attackRange = 3f;
    public LayerMask attackMask;
    public CameraShake cameraShake;
    

    public void Attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        Collider2D colInfo = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (colInfo != null)
        {

            colInfo.GetComponent<SimplePlayerMovement>().Takedamage(15);
            // Ranged attack for the enemy 
            //GameObject fireball = Instantiate(fireBall, transform) as GameObject;
            //Rigidbody2D rb = fireball.GetComponent<Rigidbody2D>();
            //rb.linearVelocity = transform.forward * 2;

            StartCoroutine(cameraShake.Shake(0.07f, 0.01f));
            Debug.Log("Player got hit ");
        }
    }

    public void RageAttack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos -= transform.up * attackOffset.y;

        Collider2D colInfo = Physics2D.OverlapCircle(pos, RageDamage, attackMask);
        if (colInfo != null)
        {
            //colInfo.GetComponent<SimplePlayerMovement>().Takedamage(20);
                
            StartCoroutine(cameraShake.Shake(0.1f, 0.01f));
            Debug.Log("Player got attacked by enemy heavily ");
        }
    }


    private void OnDrawGizmosSelected()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackOffset.x;
        pos += transform.up * attackOffset.y;

        Gizmos.DrawWireSphere(pos, attackRange);
    }
}
