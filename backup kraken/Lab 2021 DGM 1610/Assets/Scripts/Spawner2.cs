using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner2: MonoBehaviour
{
    public GameObject[] objPrefabs;
    private float spawnX = 10, spawnZ = 10, spawnInterval = 1.3f, spawnTime = 2;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRate), spawnTime,spawnInterval);
    }
    
    void SpawnRate()
    {
        int animalIndex = Random.Range(0, objPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
            
        Instantiate(objPrefabs[animalIndex], spawnPos, objPrefabs[animalIndex].transform.rotation);
    }
}