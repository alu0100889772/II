using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Energy : MonoBehaviour
{
	
	public int energia;
	
    // Start is called before the first frame update
    void Start()
    {
        energia = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increaseEnergy(int amount)
    {
        energia += amount;
    }

    public void decreaseEnergy(int amount)
    {
        energia -= amount;
    }
}
