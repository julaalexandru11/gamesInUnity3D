using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 velocity = new Vector3(0, 0, 5.0f); // in my m/s
    public float rotationSpeed = 3.0f;
    private bool isWorS_pressedDown;


    // Start is called before the first frame update
    void Start()
    {
    }



    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(0, 0, 5.0f);
        rotationSpeed = 3.0f;
        isWorS_pressedDown = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S);

        if (Input.GetKey(KeyCode.W))
        {
            // x = x [m] + v[m/s] * dt [s]
            //transform.position = transform.position + velocity * Time.deltaTime;
            transform.Translate(velocity * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // x = x [m] + v[m/s] * dt [s]
            //transform.position = transform.position + velocity * Time.deltaTime;
            transform.Translate(-velocity * Time.deltaTime);
        }



        if (Input.GetKey(KeyCode.D) && isWorS_pressedDown)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A) && isWorS_pressedDown)
        {
            transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        }
    }
}