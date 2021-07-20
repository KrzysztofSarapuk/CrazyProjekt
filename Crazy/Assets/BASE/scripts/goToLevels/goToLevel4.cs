using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToLevel4 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
    }
}
