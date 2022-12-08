using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    [SerializeField] int spawnAmount = 1000;
    [SerializeField] Vector2 spawnArea = new Vector2(100, 100);

    void Start()
    {
        for(int i = 0; i < spawnAmount; i++)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-spawnArea.x / 2, spawnArea.x / 2), Random.Range(-spawnArea.y / 2, spawnArea.y / 2),0), Quaternion.identity, transform);
        }    
    }
}
