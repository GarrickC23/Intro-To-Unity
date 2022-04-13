using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Bird should jump");
            //this.gameObject.transform.position += new Vector3(0, 5, 0);
            //myRigidBody.AddForce(new Vector2(0, 500));
            myRigidBody.velocity = new Vector2(0,5);
        }
    }
}
