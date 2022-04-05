using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private bool spawn = true;
    public Transform[] enemySpawnPoints = new Transform[5];
    public GameObject[] enemies = new GameObject[3];
    private int enemyIndex = 0;

    public Transform getEnemySpawnPoints()
    {
        int index = Random.Range(0, enemySpawnPoints.Length);
        return enemySpawnPoints[index];
    }

    public GameObject GetEnemy()
    {
        int index = Random.Range(0, enemies.Length);
        return enemies[index];
    }

    public GameObject SpawnEnemies()
    {
        Transform spawnPoint = getEnemySpawnPoints();
        GameObject enemy = GetEnemy();
        GameObject e = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation) as GameObject;
        return e;
    }
    // Start is called before the first frame update
    void Start()
    {
        enemyIndex = Random.Range(0, enemies.Length);
        while (spawn) {
            SpawnEnemies();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
