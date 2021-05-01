using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyIce : MonoBehaviour {

    public Transform startPoint;
	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.transform.position = startPoint.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "weapon")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            print("kolizja");
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            //Destroy(this.gameObject);
            print("player destroyed");
        }
    }
}
