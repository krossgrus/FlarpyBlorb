using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int highScore;
    public Text scoreText;
    public Text scoreTextDepth;
    public Text highScoreText;
    public BirdScript BirdScript;



    [ContextMenu("Add Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        scoreTextDepth.text = scoreText.text;

        if (playerScore > highScore)
        {
            highScore = playerScore;
            highScoreText.text = highScore.ToString();
        }

    }

    // Create a function that reloads the scene

    public void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Create a GameOver function that shows the gameover screen

    public GameObject gameOverScreen;  //Create the "gameOverScreen" slot on the script component in the inspector
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    private void Start()
    {
        BirdScript = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    //Let's add a visible timer
    public Text visibleTimer;

    private float alexTime;
    private double alexTimeRounded;

    private void Update()
    {
        if (BirdScript.birdIsAlive)
        {
            alexTime += Time.deltaTime;
            alexTimeRounded = System.Math.Round(alexTime, 3);
            visibleTimer.text = alexTimeRounded.ToString();

        }


    }

}
