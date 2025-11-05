using UnityEngine;

public class FishhookSpawner : MonoBehaviour
{
    public GameObject fishhookPrefab;   // Assign in Inspector
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
            SpawnFishhook();
            ScheduleNextSpawn();
        }
    }

    void SpawnFishhook()
    {
        Vector2 spawnPos = new Vector2(spawnX, Random.Range(spawnYMin, spawnYMax));
        Instantiate(fishhookPrefab, spawnPos, Quaternion.identity);
    }

    void ScheduleNextSpawn()
    {
        nextSpawnTime = Time.time + Random.Range(spawnIntervalMin, spawnIntervalMax);
    }
}