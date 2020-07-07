using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    private void OnEnable()
    {
        ChechCollisionEnter.collidedEnter += collissionPlayerAndABOrLight;
        CheckCollisionStay.collidedStay += collissionPlayerAndABOrLight;
    }

    private void OnDisable()
    {
        ChechCollisionEnter.collidedEnter -= collissionPlayerAndABOrLight;
        CheckCollisionStay.collidedStay -= collissionPlayerAndABOrLight;
    }

    void collissionPlayerAndABOrLight(GameObject player, GameObject obj)
    {
        if (player.CompareTag("Player"))
        {
            if (obj.CompareTag("TipoA"))
            {
                player.GetComponent<Energy>().increaseEnergy(1);
            }
            else if (obj.CompareTag("TipoB"))
            {
                GameObject[] objs = GameObject.FindGameObjectsWithTag(obj.tag);

                foreach (GameObject typeB in objs)
                {
                    typeB.transform.localEulerAngles = new Vector3((int)(Random.value * 360f), (int)(Random.value * 360f), (int)(Random.value * 360f));
                }
            }

            else if (obj.CompareTag("LightSwitch"))
            {
                if(Input.GetKeyDown(KeyCode.E))
                    obj.GetComponent<LightSource>().lightSource.SetActive(!obj.GetComponent<LightSource>().lightSource.activeSelf);
            }
        }
    }
}
