using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectActivationnotog : MonoBehaviour
{
    public bool activationNormalblocks = false;
    public GameObject HiddenObjects;    //main object with children that need to be hidden
    public GameObject InvisibleBlocks;  //invisible prefab block

    public bool Renderer = false;
    //private SpriteRenderer[] spriteRenderers;


    //------------------------------------------------------------------------------------------------------------------ above = all variables      below = activation key

    void Update()
    {              //activate spikes renderer, deactivate other blocks
        
           


             if (activationNormalblocks == true)   //deactivate spike renderer, activate other blocks
            {
                HiddenObjects.SetActive(true);
                Renderer = true;
            }
    

    }  
}




