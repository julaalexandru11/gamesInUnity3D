using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretMovement : MonoBehaviour
{
    public float rotationSpeed = 15.0f;
    public GameObject rock;

    // Start is called before the first frame update
    void Start()
    {
        rock = GameObject.Find("/SM_Rock_Boulder_01");
    }

    // Update is called once per frame
    void Update()
    {
        /*rotationspeed = 15.0f;

        if (input.getkey(keycode.q))
        {
            transform.rotate(0, -rotationspeed * time.deltatime, 0);
        }

        if (input.getkey(keycode.e))
        {
            transform.rotate(0, +rotationspeed * time.deltatime, 0);
        }*/

        transform.LookAt(rock.transform);
    }
}
