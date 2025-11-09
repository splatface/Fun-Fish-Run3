using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject SmallFish;
    public GameObject Plant;
    public PlayerFish Player;
    private float _delayBetweenSpawns = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            int startYFish = Random.Range(-5, 5);
            Vector3 spawnPositionFish = new Vector3(10, startYFish, 0);

            int startYPlant = Random.Range(-5, 5); 
            Vector3 spawnPositionPlant = new Vector3(10, startYPlant, 0);

            GameObject smallFish = Instantiate(this.SmallFish, spawnPositionFish, Quaternion.identity);
            GameObject plant = Instantiate(this.Plant, spawnPositionPlant, Quaternion.identity);
            yield return new WaitForSeconds(this._delayBetweenSpawns);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetCurrentIndex() == 2)
        {
            this._delayBetweenSpawns = 1.0f;
        }
        else if (Player.GetCurrentIndex() == 4)
        {
            this._delayBetweenSpawns = 0.5f;
        }
        else if (Player.GetCurrentIndex() == 6)
        {
            SceneManager.LoadScene(sceneName: "WinScreen");
        }
    }
}
