using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{

    public float rotationSpeed = 10.2f;
    public GameObject tank;
    private PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = tank.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // x = x [m] + v[m/s] * dt [s]
            //transform.position = transform.position + velocity * Time.deltaTime;
            transform.Rotate(new Vector3(+(rotationSpeed * playerMovement.rotationSpeed * Time.deltaTime),0 ,0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            // x = x [m] + v[m/s] * dt [s]
            //transform.position = transform.position + velocity * Time.deltaTime;
            transform.Rotate(new Vector3(-(rotationSpeed * playerMovement.rotationSpeed * Time.deltaTime), -(playerMovement.rotationSpeed * Time.deltaTime), 0));
        }
        /*if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -playerMovement.rotationSpeed * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, +playerMovement.rotationSpeed * Time.deltaTime, 0));
        }*/
    }
}
