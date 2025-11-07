using UnityEngine;

public class Background : MonoBehaviour
{
    public int BackgroundNumber; // set in the inspector and determines which background image it is

    private Vector3 _startPos0 = new Vector3(10f, 0);
    private Vector3 _startPos1 = new Vector3(52f, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (BackgroundNumber == 0)
        {
            transform.position = _startPos0;
        }
        else
        {
            transform.position = _startPos1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0.02f, 0);

        if (transform.position.x < -32f)
        {
            transform.position = _startPos1;
        }

    }
}
