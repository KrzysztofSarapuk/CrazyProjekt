using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    public float speed;
    public bool goingUp = true;
    public Transform Platform;
    public float UpPosition;
    public float DownPosition;

    void Start()
    {
        Platform = GetComponent<Transform>();
    }

    void Update()
    {

        // up y
        if (this.transform.localPosition.y < UpPosition && goingUp)
        {
            transform.Translate(0, speed, 0);
            if (this.transform.localPosition.y > UpPosition)
            {
                transform.Translate(0, -speed, 0);
                goingUp = !goingUp;
            }
        }

        // down y
        if (this.transform.localPosition.y > DownPosition && !goingUp)
        {
            transform.Translate(0, -speed, 0);
            if (this.transform.localPosition.y < DownPosition + 0.1)
            {
                goingUp = !goingUp;
            }
        }
    }
}
