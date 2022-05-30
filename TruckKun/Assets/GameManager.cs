using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameOverScreen GameOverScreen;
    public TestCharacterController testCharacterController;

    public void GameOver()
        {
            testCharacterController.StopTheTruck();
            GameOverScreen.Setup();
        }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
