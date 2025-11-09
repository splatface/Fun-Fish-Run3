using UnityEngine;

public class PlasticMovement : MonoBehaviour
{
    public float speed = 2.5f;
    public float offscreenX = -12f;
    public float rotationSpeed = 30f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        if (transform.position.x < offscreenX)
        {
            Destroy(gameObject);
        }
    }
}

