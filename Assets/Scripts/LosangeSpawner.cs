using UnityEngine;

public class LosangeSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject LosangePrefab;

    public float timeToSpawn = 9f;

    private float time = 0f;

    public float timeBetweenWaves = 15f;

    void Update()
    {
        time += Time.deltaTime;
        if(time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = time + timeBetweenWaves;
        } 
    }
    void SpawnBlocks()
    {
        Instantiate(LosangePrefab, spawnPoints[0].position, transform.rotation *  Quaternion.Euler(0, -60, 0));
        Instantiate(LosangePrefab, spawnPoints[1].position, transform.rotation *  Quaternion.Euler(0, -60, 0));
        Instantiate(LosangePrefab, spawnPoints[2].position, transform.rotation *  Quaternion.Euler(0, 60, 0));
        Instantiate(LosangePrefab, spawnPoints[3].position, transform.rotation *  Quaternion.Euler(0, 60, 0));
    }
}