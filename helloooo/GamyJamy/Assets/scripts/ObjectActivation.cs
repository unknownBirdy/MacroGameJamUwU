using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectActivation : MonoBehaviour
{
    public bool activationNormalblocks = true;
    public GameObject HiddenObjects;    //main object with children that need to be hidden
    public GameObject InvisibleBlocks;  //invisible prefab block

    public bool Renderer = true;
    //private SpriteRenderer[] spriteRenderers;


    //------------------------------------------------------------------------------------------------------------------ above = all variables      below = activation key

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))                //activate spikes renderer, deactivate other blocks
        {
            if (activationNormalblocks == true)
            {
                HiddenObjects.SetActive(false);
                activationNormalblocks = false;
                Renderer = false;
            }



            else if (activationNormalblocks == false)   //deactivate spike renderer, activate other blocks
            {
                HiddenObjects.SetActive(true);
                activationNormalblocks = true;
                Renderer = true;
            }
        }

    }  
}




