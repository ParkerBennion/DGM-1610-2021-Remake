using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

public class Tracer : MonoBehaviour
{
    private float power = 50;
    private Vector3 bulletPos;
    public GameObject TracerMark;

    private Quaternion flatOrient;
    //public GameObject whereItIs;

    // Update is called once per frame
    private void Start()
    {
        flatOrient.x = 0;
        flatOrient.y = 0;
        flatOrient.z = 0;
        //this sets a rotation angle variable to 0 so it can be used later
    }

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * power * Time.deltaTime);
        //bulletPos = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SilkScreen"))
        {
            Instantiate(TracerMark, transform.position, flatOrient);
            // makes the generated sprite appear flat against the camera at the position of the tracer
            Destroy(gameObject);
            
        }
    }
}
