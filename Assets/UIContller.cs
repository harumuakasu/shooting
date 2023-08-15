using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class UIContller : MonoBehaviour
{
    private int score = 0;
     GameObject scoreText;
     GameObject gameOverText;


     public void AddScore()
     {
         this.score += 10;
     }
     public void GameOver()
     {
         this.gameOverText.GetComponent<Text>().text = "GameOver";
     }
    
    
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Scor:" + score.ToString("D4");
    }
}
