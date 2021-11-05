using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    private float maxInterval = 6;
    private float minInterval = 3;

    // Start is called before the first frame update
    void Start()
    {
        
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int spawnIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnIndex], spawnPos, ballPrefabs[spawnIndex].transform.rotation);

        float spawnInterval = Random.Range(minInterval, maxInterval);
        Invoke("SpawnRandomBall", spawnInterval);
    }

}
