using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject fishFood;
    public float delayBetweenSpawns = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            int startY = Random.Range(-5, 5);
            Vector3 spawnPosition = new Vector3(2, startY, 0);
            GameObject testingObject = Instantiate(fishFood, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(delayBetweenSpawns);
        }
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
