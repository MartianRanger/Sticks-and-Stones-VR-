﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyWave
{
    public int EnemyCount;
    public GameObject enemy;
}
public class EnemySpawn : MonoBehaviour
{
    public EnemyWave[] enemyWaves;
    public Transform[] SpawnPoints;
    public float timeBetweenEnemies = 2f;

    private int currentEnemyCount;
    private int remainingEnemies;
    private int spawnedEnemies;

    private int currentWave;
    private int totalWaves;

    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        currentWave = -1;
        totalWaves = enemyWaves.Length - 1;

        StartNextWave();
        gameManager = GetComponentInParent<GameManager>();
    }

    void StartNextWave()
    {
        currentWave++;

        if(currentWave > totalWaves)
        {
            gameManager.playerWin();
        }

        currentEnemyCount = enemyWaves[currentWave].EnemyCount;
        remainingEnemies = 0;
        spawnedEnemies = 0;

        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        GameObject enemy = enemyWaves[currentWave].enemy;
        while(spawnedEnemies < currentEnemyCount)
        {
            spawnedEnemies++;
            remainingEnemies++;

            int spawnPoint = Random.Range(0, SpawnPoints.Length);

            Instantiate(enemy, SpawnPoints[spawnPoint].position, SpawnPoints[spawnPoint].rotation);

            yield return new WaitForSeconds(timeBetweenEnemies);
        }

        yield return null;
    }

    public void enemyDeath()
    {
        remainingEnemies--;

        if (remainingEnemies == 0 && spawnedEnemies == currentEnemyCount)
        {
            StartNextWave();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
