using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPlayer : MonoBehaviour
{
    
    void Update()
    {
        aimAtPlayer();
    }

    void aimAtPlayer()
    {
        Vector3 target = Move.playerPositoin;
        
        Vector3 direction = new Vector3(
            target.x - transform.position.x,
            target.y - transform.position.y - .5f,
            target.z = - transform.position.z);
        transform.forward = direction;
    }
    // takes the x,z and y position of the assigned object sets the forward orientation to that direction.
}
