using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject createPrefab;

    void Start()
    {
        for(int i = 0; i < 100; i++)
        {

            Vector3 position = new Vector3(Random.Range(-10, 10), 0, Random.Range(-100, 100));

            Instantiate(createPrefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
