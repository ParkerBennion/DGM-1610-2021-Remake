using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAATEST : MonoBehaviour
{
   
   //script is used to test various programs but not applied to anything
   
   
   
   /*{
public Vector3 mosePosxy;
public float xBound, yBound, zBound;

// Update is called once per frame
void Update()
{
   //mosePosxy = Camera.main.ScreenToWorldPoint(mosePosxy);
   mosePosxy.x = Input.mousePosition.x;
   mosePosxy.y = Input.mousePosition.y;
   mosePosxy.z = -4;
   mosePosxy = Camera.main.ScreenToWorldPoint(mosePosxy);
   transform.Translate(mosePosxy);
   if (transform.position.x < -xBound)
   {
      transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
   }
   if (transform.position.x > xBound)
   {
      transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
   }
        
   if (transform.position.y < -yBound)
   {
      transform.position = new Vector3(-yBound, transform.position.x, transform.position.z);
   }
   if (transform.position.y > yBound)
   {
      transform.position = new Vector3(yBound, transform.position.x, transform.position.z);
   }
        
   if (transform.position.z < -zBound)
   {
      transform.position = new Vector3(-zBound, transform.position.y, transform.position.x);
   }
   if (transform.position.z > zBound)
   {
      transform.position = new Vector3(zBound, transform.position.y, transform.position.x);
   }
   //^^ attempt to limit bouds to see what was happeneing as the object is flying really fast.
        
}
}
*/
//script may be used at later date
   

/*{
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
   
   //this script was a test on spawinin eneymies.
   
   
}
