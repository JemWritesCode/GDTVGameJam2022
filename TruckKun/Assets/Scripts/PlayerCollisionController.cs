using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            // Game Over
            Debug.Log("Game Over - Loading next level.");
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            int nextSceneIndex = currentSceneIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
        if(other.tag == "Normies")
        {
            Debug.Log("You hit a normal person. That's just murder.");
        }
    }
}
