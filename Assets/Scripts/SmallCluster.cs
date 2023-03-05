using UnityEngine;

public class SmallCluster : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject BlockPrefab;

    public float timeToSpawn = 14f;

    public float timeBetweenWaves = 15f;
    
    private float time = 0f;
    void Start()
    {
        time = 0f;
    }

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

        Instantiate(BlockPrefab, spawnPoints[0].position, Quaternion.identity);
        Instantiate(BlockPrefab, spawnPoints[1].position, Quaternion.identity);
        Instantiate(BlockPrefab, spawnPoints[2].position, Quaternion.identity);
    }
 
}