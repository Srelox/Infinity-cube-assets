using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSpawn : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject BlockPrefab;

    public float timeToSpawn = 6f;

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
        int randomspot = Random.Range(0,1);
            if(randomspot == 0){
                int randomRotation = Random.Range(0, 360);
                Instantiate(BlockPrefab, spawnPoints[0].position, transform.rotation *  Quaternion.Euler(0, randomRotation, 0));
                randomRotation = Random.Range(-360, 0);
                Instantiate(BlockPrefab, spawnPoints[1].position, transform.rotation *  Quaternion.Euler(0, randomRotation, 0));
            }
            else if (randomspot == 1){
                 int randomRotation = Random.Range(0, 360);
                Instantiate(BlockPrefab, spawnPoints[2].position, transform.rotation *  Quaternion.Euler(0, randomRotation, 0));
                randomRotation = Random.Range(-360, 0);
                Instantiate(BlockPrefab, spawnPoints[3].position, transform.rotation *  Quaternion.Euler(0, randomRotation, 0));
            }
    }
 
}
