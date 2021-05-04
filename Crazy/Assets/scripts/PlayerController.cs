using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpSpeed;
    private Rigidbody2D myRigidbody;
    public bool faceingRight;
    private Transform PlayerPosition;
    public Transform startPoint;

    void Start()
    {

        myRigidbody = GetComponent<Rigidbody2D>(); //access to rigidbody component
        PlayerPosition = GetComponent<Transform>(); // acces to Player position 
        //myAnim = GetComponent<Animator> ();		
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "bluestar")
        {
            PlayerPosition.transform.Rotate(0, 0, 180);
            myRigidbody.gravityScale *= -1;
            Destroy(other.gameObject);
        }

        if (other.gameObject.name == "redstar")
        {
            PlayerPosition.transform.Rotate(0, 0, 180);
            myRigidbody.gravityScale *= -1;
            Destroy(other.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {


        if (Input.GetAxisRaw("Horizontal") > 0f) //movement right
        {
            myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
            transform.localScale = new Vector2(0.5f, 0.5f);
            faceingRight = true;
        }

        else if (Input.GetAxisRaw("Horizontal") < 0f) //movement left
        {
            myRigidbody.velocity = new Vector2(-moveSpeed, myRigidbody.velocity.y);
            transform.localScale = new Vector2(-0.5f, 0.5f);
            faceingRight = false;
        }

        else
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y); // removing sliding effect

        if (Input.GetButtonDown("Jump") && myRigidbody.velocity.y == 0) //jump
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpSpeed);
        }


        if (PlayerPosition.position.y < -10)
        {
            PlayerPosition.position = startPoint.position;
        }

        if (PlayerPosition.position.y > 15)
        {
            PlayerPosition.position = startPoint.position;
        }

    }
}
