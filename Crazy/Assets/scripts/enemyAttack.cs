using System;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public Transform playerTransform;
    public Transform enemyTransform;
    Rigidbody2D enemyRgdBody;
    public int shootingRange;
    public Rigidbody kulka; // ref dla pocisku
    public Rigidbody weapon1; // ref dla pocisku
    public bool enemyFaceingRight;
    void Start()
    {       
        GameObject playerTransform = GameObject.Find("Player");
        enemyTransform = GetComponent<Transform>();
        enemyRgdBody = GetComponent<Rigidbody2D>();
    }

    void Distance()
    {

        int enemy = Convert.ToInt32(enemyTransform.position.x);
        int player = Convert.ToInt32(playerTransform.position.x);
        int distance = Math.Abs(player - enemy);

        if(enemy < player)
        {
            enemyFaceingRight = true;
        }

        if (enemy > player)
        {
            enemyFaceingRight = false;
        }

        if (distance < shootingRange)
        {
            print("distance to:  " + distance);

            EnemyShooting();

        }

    }

    void EnemyShooting()
    {
        Rigidbody instance = Instantiate(kulka, transform.position, transform.rotation) as Rigidbody;


        if (enemyFaceingRight == true)
        {


                instance.transform.Translate(0.7f, -0.3f, 0);
                //instance.transform.Rotate(0, 0, -90);
                instance.AddForce(800, 50, 0);

        }
        else
        {

                instance.transform.Translate(-1.2f, -0.3f, 0);
                instance.transform.Rotate(0, 0, 180);
                instance.AddForce(-800, 50, 0);

        }
    }

    // Update is called once per frame
    void Update()
    {
        Distance();
    }
}
