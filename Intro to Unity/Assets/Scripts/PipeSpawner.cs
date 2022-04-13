using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePair;

    public float timeBetweenSpawn = 3f;


    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawn <= 0f)
        {
            var temp = Instantiate(pipePair, transform.position, transform.rotation);
            timeBetweenSpawn = 3f;
            Destroy(temp, 3f);
        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
