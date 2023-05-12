using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class AnnouncerTrigger : MonoBehaviour
{
    public GameObject canvas;

    void Start()
    {
        canvas.SetActive(false);
    }

    void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartCoroutine(announcerList());
        }
    }



    private IEnumerator announcerList()
    {
        Debug.Log("hi");
        canvas.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        canvas.SetActive(false);
        Destroy(gameObject);
    }
}
