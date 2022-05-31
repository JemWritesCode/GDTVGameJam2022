using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerCollisionController : MonoBehaviour
{
    public MilesScore scoreManager;
    public GameManager gameManager;
    public SpawnManager spawnManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainC")
        {
                other.tag = "MainCHit";
                scoreManager.increaseHeroScore();
                Debug.Log("Attempting to destroy: " + other);
                Destroy(other.gameObject); 
        }
        if(other.tag == "SpawnTrigger") //For making more road
        {
            spawnManager.SpawnTriggerEntered();
        }
        if(other.tag == "Obstacle")
        {
            gameManager.GameOver();
        }
        if(other.tag == "Normies")
        {
            Debug.Log("You hit a normal person. That's just murder.");
            gameManager.GameOver();
        }
    }
}
