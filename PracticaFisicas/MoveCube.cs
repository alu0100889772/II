using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

	public float thrust = 0.5f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("w"))
        {
            rb.AddForce(Vector3.forward * thrust);
        }

        

        if (Input.GetKey("s"))
        {
            rb.AddForce(Vector3.back * thrust);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(Vector3.right * thrust);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(Vector3.left * thrust);
        }

        

    }
}
