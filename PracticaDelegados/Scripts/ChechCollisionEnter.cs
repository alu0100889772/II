using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChechCollisionEnter : MonoBehaviour
{
    public delegate void _collidedEnter(GameObject externalObject, GameObject collidedObject);
    public static event _collidedEnter collidedEnter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collidedEnter != null)
        {
            collidedEnter(collision.gameObject, gameObject);
        }
    }
}
