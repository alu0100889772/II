using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{

    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rend.material.color = new Color(0, 1, 0, 1);
    }

    private void OnCollisionStay(Collision collision)
    {
        rend.material.color = new Color(0.5f, 0, 0, 1);
    }

    private void OnCollisionExit(Collision collision)
    {
        rend.material.color = new Color(1,0,0,1);
    }
}
