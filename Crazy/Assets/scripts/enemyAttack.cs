using System;
using System.Collections;
using UnityEngine;

public class enemyAttack : MonoBehaviour
{
    public Transform playerTransform;
    public Transform enemyTransform;
    Rigidbody2D enemyRgdBody;
    public int shootingRange;
    public int shootingRangeY;
    public Rigidbody kulka; // ref dla pocisku
    //public Rigidbody weapon1; // ref dla pocisku
    public bool enemyFaceingRight;
    private GameObject shotedEnemyBullet;
    int counterBullets;
    public  float timeShootingDelay = 3;

    void Start()
    {       
        GameObject playerTransform = GameObject.Find("Player");
        enemyTransform = GetComponent<Transform>();
        enemyRgdBody = GetComponent<Rigidbody2D>();

        StartCoroutine(DelayEnemyShooting());
    }

    IEnumerator DelayEnemyShooting()
    {
        print("delay shooting");
        yield return new WaitForSeconds(timeShootingDelay);

        counterBullets++;
        if (counterBullets < 2)
        {
            Rigidbody instance = Instantiate(kulka, transform.position, transform.rotation) as Rigidbody;
            if (enemyFaceingRight == true)
            {
                instance.transform.Translate(0.7f, -0.3f, 0);
                instance.AddForce(900, 70, 0);

            }
            else
            {
                instance.transform.Translate(-1.2f, -0.3f, 0);
                instance.transform.Rotate(0, 0, 180);
                instance.AddForce(-900, 70, 0);
            }
        }
    }

    void Distance()
    {

        int enemy = Convert.ToInt32(enemyTransform.position.x); int enemyY = Convert.ToInt32(enemyTransform.position.y);
        int player = Convert.ToInt32(playerTransform.position.x); int playerY = Convert.ToInt32(playerTransform.position.y);
        int distance = Math.Abs(player - enemy); int distanceY = Math.Abs(playerY - enemyY);

        if (enemy < player)
        {
            enemyFaceingRight = true;
        }

        if (enemy > player)
        {
            enemyFaceingRight = false;
        }

        if (distance < shootingRange && distanceY < shootingRangeY)
        {
            EnemyShooting();
        }

    }

    void EnemyShooting()
    {

        StartCoroutine(DelayEnemyShooting());

        //counterBullets++;
        //if (counterBullets < 11)
        //{
        //    Rigidbody instance = Instantiate(kulka, transform.position, transform.rotation) as Rigidbody;
        //    if (enemyFaceingRight == true)
        //    {
        //        instance.transform.Translate(0.7f, -0.3f, 0);
        //        instance.AddForce(800, 50, 0);

        //    }
        //    else
        //    {
        //        instance.transform.Translate(-1.2f, -0.3f, 0);
        //        instance.transform.Rotate(0, 0, 180);
        //        instance.AddForce(-800, 50, 0);
        //    }
        //}
    }

    void ClearBullets()
    {
        if (GameObject.Find("bluestar(Clone)") != null)
        {
            shotedEnemyBullet = GameObject.Find("bluestar(Clone)");  // bullet wystrzelony
            if (Mathf.Abs(shotedEnemyBullet.transform.position.x - playerTransform.transform.position.x) > 12)
            {
                Destroy(shotedEnemyBullet);
            }
        }

        if (GameObject.Find("bluestar(Clone)") == null)
        {
            counterBullets = 0;
        }

    }
    void Update()
    {
        Distance();
        ClearBullets();
    }
}
