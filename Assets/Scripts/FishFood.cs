using UnityEngine;

public class FishFood : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int _speed;
    private int _xpToGive;
    private Rigidbody2D rb;
    private float appliedForce = 1000f;
    private int _startX;
    private int _startY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int randomStart = Random.Range(-100, 100);
        int randomXP = Random.Range(1, 10);
    }
    public FishFood(int speed, int xpToGive)
    {
        this._speed = speed;
        this._xpToGive = xpToGive;
    }
    public int GetXPToGive()
    {
        return _xpToGive;
    }

    public void Disappear()
    {
        Destroy(this.gameObject);
    }
    public void Travel()
    {
        rb.AddForce(new Vector2(1f * appliedForce, 0f), ForceMode2D.Impulse); // i think i have to make 1f negative to go to the left ? 
    }
}
