using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    public GameObject SharkPrefab;   // Assign in Inspector
    public float spawnIntervalMin = 2f; // Min time between spawns
    public float spawnIntervalMax = 5f; // Max time between spawns
    public float spawnYMin = -2f;       // Random vertical range
    public float spawnYMax = 2f;
    public float spawnX = 10f;          // Spawn point (offscreen right)

    private float nextSpawnTime;

    void Start()
    {
        ScheduleNextSpawn();
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnShark();
            ScheduleNextSpawn();
        }
    }

    void SpawnShark()
    {
        Vector2 spawnPos = new Vector2(spawnX, Random.Range(spawnYMin, spawnYMax));
        Instantiate(SharkPrefab, spawnPos, Quaternion.identity);
    }

    void ScheduleNextSpawn()
    {
        nextSpawnTime = Time.time + Random.Range(spawnIntervalMin, spawnIntervalMax);
    }
}