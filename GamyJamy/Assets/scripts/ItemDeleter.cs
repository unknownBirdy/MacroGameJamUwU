using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDeleter : MonoBehaviour
{
    public bool boots;
    public int gravityUp = -10;

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

            if (Input.GetKeyDown(KeyCode.F))
            {
                
            }
        }
    }
}
