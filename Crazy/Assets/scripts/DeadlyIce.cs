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
}
