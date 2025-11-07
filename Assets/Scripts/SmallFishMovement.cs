using UnityEngine;

public class SmallFish : FishFood
{
    public override void Travel()
    {
        int swimMovement = Random.Range(0, 2);
        if (swimMovement == 0)
        {
            transform.position += new Vector3(0, 0.02f, 0);
        }
        else
        {
            transform.position += new Vector3(0, -0.02f, 0);
        }
        base.Travel();
    }
}
