using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject trigger;

    void Start()
    {
        trigger.SetActive(false);
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision)
        {
            trigger.SetActive(true);
        }
    }

    void OnTriggerExit2D(UnityEngine.Collider2D collision)
    { 
        trigger.SetActive(false);
    }
}
