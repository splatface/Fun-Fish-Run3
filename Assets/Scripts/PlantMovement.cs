using UnityEngine;

public class Plant : FishFood
{
    public override void Travel()
    {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
        base.Travel();
    }
}
