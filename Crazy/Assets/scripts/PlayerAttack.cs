using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform heroTransform;
    Rigidbody2D rgdBody;
    public Rigidbody kulka; // ref dla pocisku
    private GameObject shotedBullet; // wystrzelony pocisk
    public bool faceingRight;

    void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();
        heroTransform = GetComponent<Transform>();
    }



    void FireSpell() // attack
    {
        if (Input.GetAxisRaw("Horizontal") > 0f) //movement right
        {
            faceingRight = true;
        }
        if (Input.GetAxisRaw("Horizontal") < 0f) //movement right
        {
            faceingRight = false;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
        Rigidbody instance = Instantiate(kulka, transform.position, transform.rotation) as Rigidbody;


            if (faceingRight == true)
            {
                instance.transform.Translate(0.7f, -0.3f, 0);
                //instance.transform.Rotate(0, 0, -90);
                instance.AddForce(800, 20, 0);
            }
        else
            {
                instance.transform.Translate(0f, -0.3f, 0);
                instance.transform.Rotate(0, 0, 180);
                instance.AddForce(-800, 20, 0);
            }

        //shotedBullet = GameObject.Find("kulka(Clone)");  // bullet wystrzelony
        }

    }



    // Update is called once per frame
    void Update()
    {
        FireSpell();
    }
}
