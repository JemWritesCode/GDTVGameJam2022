using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickPlayButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("MouseDownDetected");
        LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        Debug.Log("Loading next level.");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
    }

}
