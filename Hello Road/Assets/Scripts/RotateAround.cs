using UnityEngine;

//Attach this script to a GameObject to rotate around the target position.
public class RotateAround : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    private GameObject biggerSphere;

    void Start()
    {
        biggerSphere = GameObject.Find("/BiggerSphere");
    }

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(biggerSphere.transform.position, Vector3.forward, 35 * Time.deltaTime);
    }
}