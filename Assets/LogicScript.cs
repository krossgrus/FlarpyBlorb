using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public Text scoreTextDepth;



    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreTextDepth.text = scoreText.text;
    }

    //Let's add a visible timer
    public Text visibleTimer;

    private float alexTime;
    private double alexTimeRounded;

    private void Update()
    {
        alexTime += Time.deltaTime;
        alexTimeRounded = System.Math.Round(alexTime, 3);


        visibleTimer.text = alexTimeRounded.ToString();


    }

}
