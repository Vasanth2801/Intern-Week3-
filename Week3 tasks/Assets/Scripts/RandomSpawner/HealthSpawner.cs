using UnityEngine;
using UnityEngine.Rendering;

public class HealthSpawner : MonoBehaviour
{
    public Transform healthSpawner;
    public float timeToSpawn = 30f;
    public float timer;
    public ObjectPooler pooler;


    private void Start()
    {
        timer = timeToSpawn;
    }

    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            SpawnPowerup();
            timer = timeToSpawn;
        }
    }


    void SpawnPowerup()
    {
        pooler.SpawnObjects("HealthPowerup",healthSpawner.position,Quaternion.identity);
    }


}
