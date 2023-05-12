using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDeleter : MonoBehaviour
{
    public bool boots = false;
    public float gravityUp = 0f;

    //here we connect the script
    fallingPlatform _fallingPlatform;
    void Start()
    {
        _fallingPlatform = FindObjectOfType<fallingPlatform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if(boots == false)
            {
                boots = true;
                gravityUp = -8;
            }
            
            else if(boots == true)
            {
                boots = false;
                gravityUp = 0;
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "boots")
        {
            Destroy(collision.gameObject);
            Debug.Log(boots);

        }
    }
}
