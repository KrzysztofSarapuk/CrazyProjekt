using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followingHero : MonoBehaviour {

    public GameObject hero;
    private Vector3 currentVelocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3  newCameraPosition = new Vector3(hero.transform.position.x, hero.transform.position.y, -10);
        transform.position = Vector3.SmoothDamp(transform.position, newCameraPosition, ref currentVelocity, 1);
	}
}
