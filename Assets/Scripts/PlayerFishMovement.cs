using UnityEngine;

public class PlayerFishMovement : MonoBehaviour
{
    private float _movementSpeed = 6f; // how fast the fish moves
    private Vector2 _startPos = new Vector2(-2f, 0f);

    public Rigidbody2D FishBody;

    void Start()
    {
        FishBody = GetComponent<Rigidbody2D>();
        FishBody.position = _startPos;
    }

    // Update is called once per frame
    void Update()
    {
        float verticalMovement = Input.GetAxisRaw("Vertical"); // gets the vertical (ws, up, down) input

        this.FishBody.MovePosition(FishBody.position + new Vector2(0f, verticalMovement) * this._movementSpeed * Time.deltaTime);
    }
}
