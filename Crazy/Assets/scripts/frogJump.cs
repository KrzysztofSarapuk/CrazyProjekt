using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frogJump : MonoBehaviour
{
    private Transform FrogPosition;
    private Rigidbody2D FrogRigidbody;
    public int Jump;
    public int speed;
    void Start()
    {
        FrogPosition = GetComponent<Transform>(); // acces to Frog position
        FrogRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FrogJump() 
    {
        if (this.transform.localPosition.x < Jump )
        {
            //FrogRigidbody.AddForce(transform.up * 2);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
