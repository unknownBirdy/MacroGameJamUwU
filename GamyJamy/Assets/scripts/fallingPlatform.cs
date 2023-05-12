using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    public float fallDelay = 0f;
    

    [SerializeField] private Rigidbody2D rb;

    ItemDeleter _itemDeleter;

    void Start()
    {
        _itemDeleter = FindObjectOfType<ItemDeleter>();
    }


    //-------------------------------------------------------------------------------------------  call upon methods

    void Update()
    {
        rb.gravityScale = _itemDeleter.gravityUp;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //this will set the platform in action (going solemnly down)
            StartCoroutine(Fall());
            Debug.Log(_itemDeleter.boots);

            
        }
    }
   
    private void OnCollisionExit2D(Collision2D collision)
    {   
        //upon exiting the platform, it will come to a stop again
        if (collision.gameObject.CompareTag("Player"))          
        {   
            //this will stop the platform
            StartCoroutine(Stop());
        }
    }

    
   // ------------------------------------------------------------------------------------------- fall downwards method without gravity change


    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = _itemDeleter.gravityUp;
    }

    private IEnumerator Stop()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Static;
    }



    //if the platform needs to move up = not dynamic but with numbers?
    //to do: platform activated upin
}
