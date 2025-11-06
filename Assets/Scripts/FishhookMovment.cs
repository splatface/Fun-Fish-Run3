using UnityEngine;

public class FishhookMovement : MonoBehaviour
{
    public float speed = 3f;       // move speed
    public float offscreenX = -12f; // destroy when past this point

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < offscreenX)
        {
            Destroy(gameObject); // remove once offscreen
        }
    }
}

