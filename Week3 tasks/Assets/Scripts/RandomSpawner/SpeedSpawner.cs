using UnityEngine;

public class SpeedSpawner : MonoBehaviour
{
    public Transform speedSpawner;

    public float timeToSpawn = 4f;
    public float timer;
    public ObjectPooler pooler;

    void Start()
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
            SpawnObject();
            timer = timeToSpawn;
        }
    }

    void SpawnObject()
    {
         pooler.SpawnObjects("SpeedPowerup", speedSpawner.position, Quaternion.identity);
    }
}
