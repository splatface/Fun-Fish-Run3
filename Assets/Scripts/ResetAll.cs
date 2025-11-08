using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAll : MonoBehaviour
{

    public PlayerFish Player;
    public PlayerFishMovement PlayerMovement;

    public bool StartedPlaying = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        Player.Reset();
        PlayerMovement.Reset();
        SceneManager.LoadScene("ActualFFR3");
        this.StartedPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
