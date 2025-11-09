using UnityEngine;
using UnityEngine.SceneManagement;

public class PlasticCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("DeadScene");
        }
    }
}