using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
