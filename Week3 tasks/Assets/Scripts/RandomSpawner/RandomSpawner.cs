using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;

    public float timeToSpawn;

   float timer;

    private void Update()
    {
        if(timeToSpawn > 0)
        {
            timeToSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnObject();
            timeToSpawn = 30;
        }
    }
    void SpawnObject()
    { 
        Instantiate(objectToSpawn, objectToSpawn.transform);
    }
}
