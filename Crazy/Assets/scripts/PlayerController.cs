using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidbody;
	public float jumpSpeed;

	//public Transform groundCheck;
	//public float groundCheckRadius;
	//public LayerMask whatIsGround;
	//public bool isJumping;

	private Animator myAnim;

	// Use this for initialization
	void Start () {

		myRigidbody = GetComponent<Rigidbody2D> ();
		//myAnim = GetComponent<Animator> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		//isJumping = !Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

		if (Input.GetAxisRaw ("Horizontal") > 0f) {
			myRigidbody.velocity = new Vector3 (moveSpeed, myRigidbody.velocity.y, 0f);
            print("->");
			transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);
		} else if (Input.GetAxisRaw ("Horizontal") < 0f) {

			myRigidbody.velocity = new Vector3 (-moveSpeed, myRigidbody.velocity.y, 0f);
			transform.localScale = new Vector3 (-0.5f, 0.5f, 0.5f);

		} else
			myRigidbody.velocity = new Vector3 (0f, myRigidbody.velocity.y, 0f);

		if (Input.GetButtonDown ("Jump") && myRigidbody.velocity.y == 0) {
			myRigidbody.velocity = new Vector3 (myRigidbody.velocity.x, jumpSpeed, 0f);
        }

		//myAnim.SetFloat ("Speed", Mathf.Abs (myRigidbody.velocity.x));
        //myAnim.SetBool("Is_Jumping", isJumping);
        //myAnim.SetInteger("Health", 100);

	}
}
