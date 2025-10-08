using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firepoint;
    public ObjectPooler pooler;
    public GameObject Bullet;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            Shoot();
        }
    }

    void Shoot()
    {
         pooler.SpawnObjects("Bullet",firepoint.position,firepoint.rotation);
    }
}
