using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public int playerScore;    
    public Text scoreText;
    public Text highestScoreText;
    public GameObject gameOverScreen;
    public AudioSource dingSFX;
    public AudioSource gameOverSound;
    public ParticleSystem clouds;
    [ContextMenu("Increase Score!")]
    public void Start()
    {
        highestScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore", 0).ToString();//by default our at the start our high score will always be 0
    }
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        dingSFX.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(1);        
    }

    public void backtoMenu()
    {
        SceneManager.LoadScene(0);
        clouds = GameObject.FindGameObjectWithTag("Cloud").GetComponent<ParticleSystem>();
        Destroy(clouds);
    }

    public void gameOver()
    {
        gameOverSound.Play();       
        gameOverScreen.SetActive(true);    
        
        if(playerScore > PlayerPrefs.GetInt("highScore",0))//checks if the new score is bigger than our setted before
        {
            PlayerPrefs.SetInt("highScore", playerScore);//give the new highest score the value of the new one 
            highestScoreText.text = "High Score: " + playerScore.ToString();//show it on the screen
        }
    }
}
