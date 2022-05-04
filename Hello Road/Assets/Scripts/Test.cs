using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    Transform t;
    PlayerMovement playerMovement;
    void Start()
    {
        t = GetComponent<Transform>();
        playerMovement = GetComponent<PlayerMovement>();

        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.rotationSpeed = playerMovement.rotationSpeed * 1.01f;
    }
}
