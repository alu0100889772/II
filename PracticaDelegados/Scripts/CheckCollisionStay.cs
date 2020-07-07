using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisionStay : MonoBehaviour
{
    public delegate void _collidedStay(GameObject externalObject, GameObject collidedObject);
    public static event _collidedStay collidedStay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collidedStay != null)
        {
            collidedStay(collision.gameObject, gameObject);
        }
    }
}
