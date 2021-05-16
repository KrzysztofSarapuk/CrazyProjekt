using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class responitPoint : MonoBehaviour
{
    public Transform newRespointPoint;
    public Transform oldRespointPoint;

    void Start()
    {
        GameObject respointTransform = GameObject.Find("respointPoint");
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            oldRespointPoint.position = newRespointPoint.position;
            Destroy(gameObject);
        }
    }
}
