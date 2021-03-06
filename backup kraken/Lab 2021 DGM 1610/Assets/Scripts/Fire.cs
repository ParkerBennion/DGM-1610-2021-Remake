using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gun;
    public GameObject tracer;
    public float trigger = 2f;
    private float triggerDelay;

    public Quaternion trajectory;

    private void Start()
    {
        triggerDelay = trigger;
        ShootNow();
    }

    void Update()
    {
        triggerDelay -= Time.deltaTime;
        if (triggerDelay < 1 && StatusManager.gameActive)
        {
            ShootNow();
        }
        trajectory = transform.rotation; //records data in qaternion of the objects rotation and updates every frame.
    }

    void ShootNow()
    {
        Instantiate(bullet, gun.transform.position, trajectory); // on left click spawn (insert variable X) at (insert variable Y) with rotation matching "trajectory"
            Instantiate(tracer, gun.transform.position, trajectory);
            triggerDelay = 3;
    }
    
}
