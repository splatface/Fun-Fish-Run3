using UnityEngine;

public class PlayerFishMovement : MonoBehaviour
{
    private float _movementSpeed = 5f;
    private Vector3 _startPos = new Vector3(-2f, 0f, 0);

    void Start()
    {
        transform.position = this._startPos;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxisRaw("Vertical");

        transform.position += _movementSpeed * Time.deltaTime * new Vector3(0f, verticalMovement);
    }
}
