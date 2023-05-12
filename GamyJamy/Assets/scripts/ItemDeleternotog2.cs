using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDeleternotog2 : MonoBehaviour
{
    ObjectActivationnotog _objectActivation;

    //here we connect the script
    void Start()
    {
        _objectActivation = FindObjectOfType<ObjectActivationnotog>();
    }


   public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "glasses")
        {
            Destroy(collision.gameObject);
            _objectActivation.activationNormalblocks = true;
            
        }

} }