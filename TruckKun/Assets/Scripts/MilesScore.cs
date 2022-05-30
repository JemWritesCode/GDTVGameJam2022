using UnityEngine;
using TMPro;
using System;

public class MilesScore : MonoBehaviour
{

    public Transform player;
    public TextMeshProUGUI scoreMilesText;
    public TextMeshProUGUI scoreHeroText;
    public double milesScoring = 0;
    public int heroScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        milesScoring = Math.Round((player.position.z - 11.78)/100, 2);
        scoreMilesText.text = milesScoring.ToString();
        scoreHeroText.text = heroScore.ToString();
    }

    public void increaseHeroScore()
    {
        heroScore++;
    }
}
