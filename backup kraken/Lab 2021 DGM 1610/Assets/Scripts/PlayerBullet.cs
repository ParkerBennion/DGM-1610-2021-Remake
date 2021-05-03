using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private float power = 15;
    public GameObject SecondRetryButton;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * power * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BOSS"))
        {
            StatusManager.gameActive = false;
            ScoreKeeper.Score++;
            SecondRetryButton.SetActive(true);
        }
        // if it goes out of bounds delete it.
        // gets destroyed on trigger and adds points if the tag is the player bullet
    }
    // simple moving script for player bullet to go faster
}
