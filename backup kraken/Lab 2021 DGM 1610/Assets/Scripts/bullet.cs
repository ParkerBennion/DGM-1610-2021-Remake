using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private float power = 7;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * power * Time.deltaTime);
    }
    // simple moving script
}
