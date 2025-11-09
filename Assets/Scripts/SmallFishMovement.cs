using UnityEngine;

public class SmallFish : FishFood
{
    public override void Travel()
    {
        int swimMovement = Random.Range(0, 2);
        if (swimMovement == 0)
        {
            this.transform.position += new Vector3(0, 0.02f, 0);
        }
        else
        {
            this.transform.position += new Vector3(0, -0.02f, 0);
        }
        base.Travel();
    }
}
