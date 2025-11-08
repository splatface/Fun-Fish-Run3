using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoStart : MonoBehaviour
{
    private Scene _currentScene;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
    _currentScene = SceneManager.GetActiveScene();
        
    }

    void OnMouseDown()
    {
        if (_currentScene.name == "StartScreen")
        {
            SceneManager.LoadScene("InfoScene");
        }
        else
        {
            SceneManager.LoadScene("StartScreen");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
