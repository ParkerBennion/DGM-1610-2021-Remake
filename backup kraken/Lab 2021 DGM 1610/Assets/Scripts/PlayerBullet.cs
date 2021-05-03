using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private float power = 15;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * power * Time.deltaTime);
    }
    // simple moving script for player bullet to go faster
}
