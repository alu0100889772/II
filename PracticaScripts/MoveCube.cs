using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{

	public float speed = 0.1f;
    public float angleRotation = 5f;
    private Transform transf;

    // Start is called before the first frame update
    void Start()
    {
        transf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey("d"))
        {
            transf.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }

        if (Input.GetKey("a"))
        {
            transf.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }

        if (Input.GetKey("w"))
        {
            transf.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }

        if (Input.GetKey("s"))
        {
            transf.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }

        if (Input.GetKey("q"))
        {
            transf.Rotate(transf.rotation.x, transf.rotation.y - angleRotation, transf.rotation.z, Space.World);
        }

        if (Input.GetKey("e"))
        {
            transf.Rotate(transf.rotation.x, transf.rotation.y + angleRotation, transf.rotation.z, Space.World);
        }

        if (Input.GetKey("space"))
        {
            transf.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }

        if (Input.GetKey("left shift"))
        {
            transf.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
        }

    }
}
