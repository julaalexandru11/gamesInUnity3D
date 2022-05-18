using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;
    public GameObject powerupIndicator;
    void Start()
    {
        Instantiate(powerupIndicator, GenerateSpawnPosition(), powerupIndicator.transform.rotation);
        SpawnEnemyWave(waveNumber);
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0;  i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        /* for(int i = 0; i < 5; i++)
        {
            Vector3 randomPositions = new Vector3(Random.Range(-spawnRange, +spawnRange), 0, Random.Range(-spawnRange, +spawnRange));
            Instantiate(enemyPrefab, randomPositions, enemyPrefab.transform.rotation);
        }*/
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }

        

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        
        if(enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupIndicator, GenerateSpawnPosition(), powerupIndicator.transform.rotation);
        }
    }
}
