using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * This script spawns in obstacles from an array of game objects
 * 
 */ 
public class mapSpawner : MonoBehaviour
{
    public GameObject[] obstacleArr;
    private float obstacleSpawnInterval = 4.5f;

    private void SpawnObstacle()
    {
        int random = Random.Range(0, obstacleArr.Length); // chooses random number within the array
        Instantiate((obstacleArr[random]), new Vector3(transform.position.x, Random.Range(-4, 1), 1), Quaternion.identity);        
    }
    
    IEnumerator SpawnObstacles()
    {
        while (true) // constantly spawns in obstacles with a time gap specified by obstacleSpawnInterval
        {
            SpawnObstacle();
            yield return new WaitForSeconds(obstacleSpawnInterval);
        }
    }
    void Start()
    {
        StartCoroutine(SpawnObstacles()); // Starts the IEnumerator
    }

}
