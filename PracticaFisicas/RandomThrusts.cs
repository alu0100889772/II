using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomThrusts : MonoBehaviour
{


    public float strenght;
    private Rigidbody rb;
    private System.Random randomDirection;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        strenght = 0.001f;
        randomDirection = new System.Random();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        int direction = randomDirection.Next(4);

        if(direction==0)
            rb.AddRelativeForce(Vector3.forward * strenght);
        else if(direction==1)
            rb.AddRelativeForce(Vector3.back * strenght);
        else if (direction == 2)
            rb.AddRelativeForce(Vector3.right * strenght);
        else
            rb.AddRelativeForce(Vector3.left * strenght);
    }
}
