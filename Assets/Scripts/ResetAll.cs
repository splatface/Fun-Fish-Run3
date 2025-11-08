using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAll : MonoBehaviour
{

    public PlayerFish Player;
    public PlayerFishMovement PlayerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        Player.Reset();
        PlayerMovement.Reset();
        SceneManager.LoadScene("ActualFFR3");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
