using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDead : MonoBehaviour
{
    public Transform startPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "bluestar")
        {
            other.transform.position = startPoint.position;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bluestar")
        {
            Destroy(this.gameObject);
            print("kolizja");
        }
    }
}
