using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOffRenderer : MonoBehaviour
{
    ObjectActivation _objectActivation;


    void Start()
    {
        _objectActivation = FindObjectOfType<ObjectActivation>();
    }

    //------------------------------------------------------------------------------------------------------------------ above = all variables

    void Update()
    {
        if (_objectActivation.Renderer == true)                 //deactivation renderer variable
        {
            this.GetComponent<SpriteRenderer>().enabled = false;
        }

        else if (_objectActivation.Renderer == false)           //activation renderer variable
        {
            this.GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
