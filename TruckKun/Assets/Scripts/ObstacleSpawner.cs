using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private int spawnInterval = 11;
    private int lastSpawnZ = 22;
    private int spawnAmount = 4;


    public List<GameObject> obstacles;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void SpawnObstacles()
    {
       for (int i = 0; i < spawnAmount; i++)
       {
            Debug.Log("Inside Spawn Obstacles");
           lastSpawnZ += spawnInterval;

           //Chance 33%
           if (Random.Range(0,4) == 0)
           {
               GameObject obstacle = obstacles[Random.Range(0, obstacles.Count)];
               Instantiate(obstacle, new Vector3(0, 0, lastSpawnZ), obstacle.transform.rotation);
           }
       }
    }
}
