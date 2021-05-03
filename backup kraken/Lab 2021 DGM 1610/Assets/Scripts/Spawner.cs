using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using System;

/*public class Spawner : MonoBehaviour
{
    public GameObject[] objPrefabsss;
    public float startDelay, repeatRate;
    public GameObject[] spawnPoints;
    private float spawnRate = 1.5f;
    public GameObject testObj;

    private void Start()
    {
        StartCoroutine(startSpawning());
    }

    IEnumerator startSpawning()
    {
        Instantiate(testObj);
        while (StatusManager.gameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int objindex = Random.Range(0, objPrefabsss.Length);
            gameObject spawnIndex = Random.Range(0, spawnPoints.Length);
            Instantiate(objPrefabsss[objindex], spawnPoints[spawnIndex].transform);
        }

    }

    // Start is called before the first frame update
    /* void Start()
     {
         int _randomSpawnInt = Random.Range(3, 10);
         InvokeRepeating(nameof(SpawnRandomObj), startDelay, repeatRate);
         jumpscript = GameObject.Find("player").GetComponent<Jump>();
     }*/

    //this doesnt work because it cannot track an item that doesnt exist yet

    /* void SpawnRandomObj ()
     {
         if (jumpscript.gameOver == false)
         {
             int objLibrary = Random.Range(0, objPrefabsss.Length);
             // Generate random ball index and random spawn position
         
 
             // instantiate ball at random spawn location
             Instantiate(objPrefabsss[objLibrary], spawnPos, objPrefabsss[objLibrary].transform.rotation);
         }
     }*/
//}