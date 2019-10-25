using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidBody : MonoBehaviour
{
    // Start is called before the first frame update

    public float thrust = 2;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {

        

        if (Input.GetKey("i"))
        {
            rb.AddForce(Vector3.forward * thrust);
        }

        if (Input.GetKey("m"))
        {
            rb.AddForce(Vector3.back * thrust);
        }

        if (Input.GetKey("l"))
        {
            rb.AddForce(Vector3.right * thrust);
        }

        if (Input.GetKey("j"))
        {
            rb.AddForce(Vector3.left * thrust);
        }


    }
}
