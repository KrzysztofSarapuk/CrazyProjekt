using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform teleportPoint;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            other.transform.position = teleportPoint.position;
        }
    }

}
