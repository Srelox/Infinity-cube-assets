using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject BlockPrefab;

    public float timeToSpawn = 0f;

    public float timeBetweenWaves = 5f;

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
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(BlockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
