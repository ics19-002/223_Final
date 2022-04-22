using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] private List<Transform> enemyPositions;
    [SerializeField] private List<GameObject> enemyPrefabs;
    public bool spawn = true;

    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {
        while (spawn)
        {
            if (enemyPrefabs != null)
            {
                yield return new WaitForSeconds(2.5f);
                Vector3 randomPos = GetRandomPosition();
                GameObject newEnemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Count)], randomPos, Quaternion.identity);
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
