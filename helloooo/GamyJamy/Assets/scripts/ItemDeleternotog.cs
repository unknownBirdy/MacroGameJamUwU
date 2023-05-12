using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDeleternotog : MonoBehaviour
{
    public bool boots = false;
    public float gravityUp = 0f;

    //here we connect the script
    fallingPlatform _fallingPlatform;
    void Start()
    {
        _fallingPlatform = FindObjectOfType<fallingPlatform>();
    }



    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "boots")
        {
            Destroy(collision.gameObject);
            Debug.Log(boots);
            boots = true;
            gravityUp = -12;
        }

}   }
