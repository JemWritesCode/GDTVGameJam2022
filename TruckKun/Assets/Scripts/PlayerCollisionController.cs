using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionController : MonoBehaviour
{
    public MilesScore scoreManager;

    public SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainC")
        {
            scoreManager.increaseHeroScore();
            Destroy(other.gameObject);
        }
        if(other.tag == "SpawnTrigger") //For making more road
        {
            spawnManager.SpawnTriggerEntered();
        }
        if(other.tag == "Obstacle")
        {
            Debug.Log("You crashed the truck. Now you can't save anyone.");
        }
        if(other.tag == "Normies")
        {
            Debug.Log("You hit a normal person. That's just murder.");
        }
    }
}
