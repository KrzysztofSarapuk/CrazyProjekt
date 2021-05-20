using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpSpeed;
    private Rigidbody2D myRigidbody;
    public bool faceingRight;
    private Transform PlayerPosition;
    public Transform startPoint;

    private float time = 0.0f;

    Animator anim;

    void Start()
    {

        myRigidbody = GetComponent<Rigidbody2D>(); //access to rigidbody component
        PlayerPosition = GetComponent<Transform>(); // acces to Player position 
        anim = GetComponent<Animator> ();		
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


    void TimeEndJump()
    {
        time = time + Time.fixedDeltaTime;
        if (time > 1.7f)
        {
            //Debug.Log(gameObject.transform.position.y + " : " + time);
            anim.SetBool("jump", false);
            time = 0.0f;
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
            anim.SetFloat("speed", 1);
        }

        else if (Input.GetAxisRaw("Horizontal") < 0f) //movement left
        {
            myRigidbody.velocity = new Vector2(-moveSpeed, myRigidbody.velocity.y);
            transform.localScale = new Vector2(-0.5f, 0.5f);
            faceingRight = false;
            anim.SetFloat("speed", 1);
        }




        else
            myRigidbody.velocity = new Vector2(0f, myRigidbody.velocity.y); // removing sliding effect

        if (Input.GetButtonDown("Jump") && myRigidbody.velocity.y == 0) //jump
        {
            anim.SetBool("jump", true);
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpSpeed);
        }
        TimeEndJump();

        if (PlayerPosition.position.y < -10)
        {
            PlayerPosition.position = startPoint.position;
        }

        if (PlayerPosition.position.y > 35)
        {
            PlayerPosition.position = startPoint.position;
        }

        if (Input.GetAxisRaw("Horizontal") == 0f) //movement left
        {
            anim.SetFloat("speed", 0);
        }

    }
}
