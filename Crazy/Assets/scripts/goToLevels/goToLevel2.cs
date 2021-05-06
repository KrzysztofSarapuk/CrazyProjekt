using UnityEngine;

public class goToLevel2 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player")
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
    }
}
