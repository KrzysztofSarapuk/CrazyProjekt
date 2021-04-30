using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Transform heroTransform;
    Rigidbody2D rgdBody;
    public Rigidbody kulka; // ref dla pocisku
    private GameObject shotedBullet; // wystrzelony pocisk

    void Start()
    {
        rgdBody = GetComponent<Rigidbody2D>();
        heroTransform = GetComponent<Transform>();
    }

    void FireSpell() // attack
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
        print("fire spell");
        Rigidbody instance = Instantiate(kulka, transform.position, transform.rotation) as Rigidbody;
        shotedBullet = GameObject.Find("kulka(Clone)");  // bullet wystrzelony

        instance.transform.Translate(0.7f, -0.3f, 0);
        //instance.transform.Rotate(0, 0, -90);
        instance.AddForce(800, 20, 0);

        }
    }



    // Update is called once per frame
    void Update()
    {
        FireSpell();
    }
}
