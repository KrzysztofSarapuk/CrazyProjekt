using UnityEngine;

public class movingEnemy : MonoBehaviour {

    public float speed;
    public bool faceingLeft = true;
    public Transform Enemy;
    public float leftPosition;
    public float RightPosition;

    void Start () {
        Enemy = GetComponent<Transform>();
    }

    void Update () {

        // movement left to position x
        if (this.transform.localPosition.x > leftPosition && faceingLeft)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            if (this.transform.localPosition.x < leftPosition)
            {
                transform.Translate(speed, 0, 0);
                faceingLeft = !faceingLeft;
                Enemy.Rotate(0, 180, 0);
            }
        }

        // movement right to position x
        if (this.transform.localPosition.x < RightPosition && !faceingLeft)
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            if (this.transform.localPosition.x > RightPosition - 0.1)
            {
                faceingLeft = !faceingLeft;
                Enemy.Rotate(0, 180, 0);
            }
        }
    }
}
