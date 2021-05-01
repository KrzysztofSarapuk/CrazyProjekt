using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform heroTransform;
    Rigidbody2D rgdBody;
    public Rigidbody kulka; // ref dla pocisku
    public Rigidbody weapon1; // ref dla pocisku
    public Rigidbody weapon2; // ref dla pocisku
    public Rigidbody weapon3; // ref dla pocisku
    public Rigidbody weapon4; // ref dla pocisku
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


        if (Input.GetKeyDown(KeyCode.Alpha1)) // choice weapon
        {
            kulka = weapon1;
        }


        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            kulka = weapon2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            kulka = weapon3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            kulka = weapon4;
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
