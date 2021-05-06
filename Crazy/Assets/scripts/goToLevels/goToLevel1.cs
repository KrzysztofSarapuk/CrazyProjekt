using UnityEngine;

public class goToLevel1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}
