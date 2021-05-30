using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyBridge : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "weapon")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
