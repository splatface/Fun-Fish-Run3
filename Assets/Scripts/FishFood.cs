using UnityEngine;

public class FishFood : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int _speed;
    private int _xpToGive;

    void Start()
    {
        int randomSpeed = Random.Range(4, 10);
        int randomXP = Random.Range(15, 40);
        this._speed = randomSpeed;
        this._xpToGive = randomXP;

    }
    void Update()
    {
        this.Travel();
        if (transform.position.x <= -11)
        {
            this.Disappear();
        }
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
        Vector3 addPosition = new Vector3(-0.005f * this._speed, 0, 0);
        transform.position += addPosition;
    }
}
