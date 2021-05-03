using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill : MonoBehaviour
{

    public GameObject particle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerBullet"))
        {
            Instantiate(particle, transform.position, transform.rotation);
            Destroy(gameObject);
            ScoreKeeper.Score++;
        }
        // if it dies by a player bullet add a point
        else if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
        // if it hits a player delete it
        else if (other.CompareTag("OB"))
        {
            Destroy(gameObject);
        }
        // if it goes out of bounds delete it.
        // gets destroyed on trigger and adds points if the tag is the player bullet
    }
}
