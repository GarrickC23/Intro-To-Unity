using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float pipeSpeed = .01f;

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += Vector3.left * Time.deltaTime * pipeSpeed;
    }
}
