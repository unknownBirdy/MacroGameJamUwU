using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    private float fallDelay = 0.5f;
    private float destroyDelay = 2f;

    [SerializeField] private Rigidbody2D rb;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Fall());
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {   //upon exiting the platform, it will come to a stop again
        StopCoroutine(Fall());
    }

    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(fallDelay);
        rb.bodyType = RigidbodyType2D.Dynamic;
        Destroy(gameObject, destroyDelay);
    }



    //if the platform needs to move up = not dynamic but with numbers?
    //to do: platform activated upin
}
