using UnityEngine;

public class SpeedSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float timeToSpawn;

    public float spawningTime;
    private float timer;
    void Update()
    {
        if(spawningTime > 0)
        {
            spawningTime -= Time.deltaTime;
        }
        else
        {
            SpawnSpeedObject();
            spawningTime = 20f;
        }
    }

    void SpawnSpeedObject()
    {
        Instantiate(objectToSpawn, objectToSpawn.transform);
    }
}
