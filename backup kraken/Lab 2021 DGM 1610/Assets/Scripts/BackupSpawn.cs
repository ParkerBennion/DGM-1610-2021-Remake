using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class BackupSpawn : MonoBehaviour
{
    public GameObject[] objPrefabs;
    private float spawnX = 9, spawnZ = 9.7f, spawnInterval = 1.3f, spawnTime = 2;
    public GameObject boss;
    public static bool bossT;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnRate), spawnTime,spawnInterval);
        bossT = true;
    }

    private void Update()
    {
        if (ScoreKeeper.Score == 20 && bossT)
        {
            Bosstime();
        }
    }
    //summons boss when score hits 20

    void SpawnRate()
    {
        int animalIndex = Random.Range(0, objPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX),Random.Range(1f,8f), spawnZ);
            
        Instantiate(objPrefabs[animalIndex], spawnPos, objPrefabs[animalIndex].transform.rotation);
        if (!StatusManager.gameActive)
        {
            CancelInvoke();
        }
        //stops this from repeating
    }

    void Bosstime()
    {
        Vector3 spawnPos = new Vector3(.36f, 5f, 9.76f);
        Instantiate(boss, spawnPos, transform.rotation);
    }
    
    //sets up a spawnrate and posistion for enemies.
}