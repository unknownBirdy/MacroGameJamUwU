using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public Transform firePoint;
    public 
    

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))   //upon button press the shoot method will be executed
        {
            Shoot();
        }
    }


    void Shoot()
    {

        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);      //

        if (hitInfo)
        {
            if (hitInfo.collider.CompareTag("shootPlat"))
            {
                Debug.Log("Hit");
            }
        }
    }
}
