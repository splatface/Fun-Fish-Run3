using UnityEngine;

public class PlasticSpawner : MonoBehaviour
{
    public GameObject plasticPrefab;
    public float spawnIntervalMin = 3f;
    public float spawnIntervalMax = 7f;
    public float spawnYMin = -4f;
    public float spawnYMax = 4f;
    public float spawnX = 10f;

    private float nextSpawnTime;

    void Start()
    {
        ScheduleNextSpawn();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnPlastic();
            ScheduleNextSpawn();
        }
    }

    void SpawnPlastic()
    {
        Vector2 spawnPos = new Vector2(spawnX, Random.Range(spawnYMin, spawnYMax));
        Instantiate(plasticPrefab, spawnPos, Quaternion.identity);
    }

    void ScheduleNextSpawn()
    {
        nextSpawnTime = Time.time + Random.Range(spawnIntervalMin, spawnIntervalMax);
    }
}