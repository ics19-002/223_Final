using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] private List<Transform> enemyPositions;
    [SerializeField] private GameObject enemyPrefab;
    private bool spawn = true;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (spawn)
        {
            if (enemyPrefab != null)
            {
                yield return new WaitForSeconds(5f);
                Vector3 randomPos = GetRandomPosition();
                GameObject newEnemy = Instantiate(enemyPrefab, randomPos, Quaternion.identity);
            }
            else
            {
                Debug.LogWarning("Enemy prefab not assigned.");
            }
        }
    }

    private Vector3 GetRandomPosition()
    {
        if (enemyPositions.Count > 0)
        {
            return enemyPositions[Random.Range(0, enemyPositions.Count)].position;
        } else
        {
            return Vector3.zero;
        }
    }

}
