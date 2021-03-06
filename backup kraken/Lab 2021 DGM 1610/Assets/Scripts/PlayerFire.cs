using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bullet;
    public GameObject gun;
    public Quaternion trajectory;

    void Update()
    {
        trajectory = transform.rotation; //records data in qaternion of the objects rotation and updates every frame.
        if (Input.GetKeyDown(KeyCode.Mouse0) && StatusManager.gameActive)
        {
            Instantiate(bullet, gun.transform.position, trajectory); // on left click spawn (insert variable X) at (insert variable Y) with rotation matching "trajectory"
        }
        //Debug.Log(trajectory); //display current trajectory
    }
}
