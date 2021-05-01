using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
    public float jumpSpeed;
    private Rigidbody2D myRigidbody;
    public bool faceingRight;

    //public Transform groundCheck;
    //public float groundCheckRadius;
    //public LayerMask whatIsGround;
    //public bool isJumping;

    //private Animator myAnim;

    // Use this for initialization
    void Start () {

		myRigidbody = GetComponent<Rigidbody2D> (); //access to rigidbody component
		//myAnim = GetComponent<Animator> ();		
	}
	
	// Update is called once per frame
	void Update () {

		//isJumping = !Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);

		if (Input.GetAxisRaw ("Horizontal") > 0f) //movement right
        {
			myRigidbody.velocity = new Vector2 (moveSpeed, myRigidbody.velocity.y);
			transform.localScale = new Vector2 (0.5f, 0.5f);
            faceingRight = true;
        }

        else if (Input.GetAxisRaw ("Horizontal") < 0f) //movement left
        {
			myRigidbody.velocity = new Vector2 (-moveSpeed, myRigidbody.velocity.y);
			transform.localScale = new Vector2 (-0.5f, 0.5f);
            faceingRight = false;
        }

        else
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y); // removing sliding effect

        if (Input.GetButtonDown ("Jump") && myRigidbody.velocity.y == 0) //jump
        {
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpSpeed);
        }

		//myAnim.SetFloat ("Speed", Mathf.Abs (myRigidbody.velocity.x));
        //myAnim.SetBool("Is_Jumping", isJumping);
        //myAnim.SetInteger("Health", 100);

	}
}
