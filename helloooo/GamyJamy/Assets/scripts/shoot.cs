using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject _firePoint;
    public GameObject shootPlat;

    public float movedirection = 0.0f;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    
    //---------------------------------------------------------------------------------------- above = all variables        below = shoot function

    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

        try
        {
            if (hitInfo.collider.CompareTag("shootPlat"))
            {
                if(_firePoint.transform.position.x > shootPlat.transform.position.x)
                {
                    movedirection = 2.0f;
                }
                else if (_firePoint.transform.position.x < shootPlat.transform.position.x)
                {
                    movedirection = -2.0f;
                }

                Debug.Log(hitInfo.collider.name);
            }
        }
        catch (Exception)
        {   
            //catch the exception if nothing is hit
            Debug.Log("not hit");
        }
        
    }
}

