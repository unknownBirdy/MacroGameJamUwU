using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firePoint;
    private Vector3 _lastPosition;
    private Transform currentPosition;

    [SerializeField] private LayerMask shootPlat;

   /* void Start()
    {
        // set initial value for lastPosition
        _lastPosition = this.transform.position;
    }
    */
    void Update()
    {/*
        // get current position
        currentPosition = this.transform.position;

        // do anything you need to with the positions        CODE
        
        // set last to current so the next frame of Update() is ready
        _lastPosition = this.transform.position;
        */

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    void Shoot()
    {

        //this sets the direction of the "shot"
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right, shootPlat.value);

        try
        {
            if (hitInfo)
            {   //check the Tag and output "Hit" if true
                Debug.Log(hitInfo.collider.name);
            }
        }

        catch (Exception e)
        {   //catch the exception if nothing is hit
            Debug.Log("not hit");
        }
        
    }
}

