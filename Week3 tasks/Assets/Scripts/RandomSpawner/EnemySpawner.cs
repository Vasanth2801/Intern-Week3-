using TMPro;
using UnityEngine;


[System.Serializable]
public class Wave
{
    public string waveName;
    public int noOfEnemies;
    public GameObject[] enemies;
    public int spawnInterval;
}

public class EnemySpawner : MonoBehaviour
{
    public Wave[] waves;
    public Transform[] spawnPoints;
    public Animator animator;
    private Wave currentWave;
    private int currentWaveIndex;
    private float spawnTime;
    private bool canSpawn = true;
    private bool canAnimate = false;
    public TextMeshProUGUI waveText;

    private void Update()
    {
        currentWave = waves[currentWaveIndex];
        SpawnWave();
        GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(totalEnemies.Length == 0 && currentWaveIndex+1 != waves.Length && canAnimate)
        {
            waveText.text = waves[currentWaveIndex + 1].waveName;
            animator.SetTrigger("WaveComplete");
            canAnimate = false;
            SpawnAnotherWave();
        }
        else
        {
            Debug.Log("WavesComplete");
        }
    }

    void SpawnAnotherWave()
    {
        currentWaveIndex++;
        canSpawn = true;
    }

    void SpawnWave()
    {
        if(canSpawn && spawnTime < Time.time)
        {
            GameObject randomEnemy = currentWave.enemies[Random.Range(0, currentWave.enemies.Length)];
            Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
            currentWave.noOfEnemies--;

            spawnTime = Time.time + currentWave.spawnInterval;
            if(currentWave.noOfEnemies == 0)
            {
                canSpawn = false;
                canAnimate = true;
            }
        }


       
    }

}
