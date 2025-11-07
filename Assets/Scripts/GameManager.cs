using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject SmallFish;
    public GameObject Plant;
    public float delayBetweenSpawns = 1.5f;

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
            GameObject smallFish = Instantiate(SmallFish, spawnPositionFish, Quaternion.identity);
            GameObject plant = Instantiate(Plant, spawnPositionPlant, Quaternion.identity);
            yield return new WaitForSeconds(delayBetweenSpawns);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
