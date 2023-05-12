using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootPlatformScript : MonoBehaviour
{
    public bool stopMoving = true;
    public GameObject button;

    [SerializeField] private Rigidbody2D rb;

    shoot _shoot;

    void Start()
    {
        _shoot = FindObjectOfType<shoot>();
    }


    //---------------------------------------------------------------- above = all variables


    void Update()
    {
        rb.velocity = new Vector2(_shoot.movedirection, 0.0f);
    }
}
