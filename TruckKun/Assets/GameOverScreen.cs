using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    //public Text pointsText;

    public void Setup()
    {
        gameObject.SetActive(true);
        //pointsText.text = score.ToString() + " HEROES MADE";
    }

    public void RestartButton()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void ExitButton()
    {
        // Back to Main Menu
        SceneManager.LoadScene(0);
    }
}
