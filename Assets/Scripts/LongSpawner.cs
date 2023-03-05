using UnityEngine;

public class LongSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject LongPrefab;

    private float time = 0f;

    public float timeToSpawn = 1.5f;

    public float timeBetweenWaves = 3f;
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
        int randomRotation = Random.Range(55, 75);

        if(randomIndex == 0)
            {
                Instantiate(LongPrefab, spawnPoints[0].position, transform.rotation *  Quaternion.Euler(0, randomRotation, 0));
                Instantiate(LongPrefab, spawnPoints[1].position, transform.rotation *  Quaternion.Euler(0, randomRotation, 0));
            
            }
        else {
            Instantiate(LongPrefab, spawnPoints[1].position, transform.rotation *  Quaternion.Euler(0, -randomRotation, 0));
            Instantiate(LongPrefab, spawnPoints[0].position, transform.rotation *  Quaternion.Euler(0, -randomRotation, 0));
        }
    
    }
}