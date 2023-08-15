using System.Collections;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIContller : MonoBehaviour
{
    private int score = 0;
    [SerializeField]TextMeshProUGUI scoreText;
    [SerializeField]TextMeshProUGUI gameOverText;


     public void AddScore()
     {
         this.score += 10;
     }
     public void GameOver()
     {
         this.gameOverText.text = "GameOver";
     }

    // Update is called once per frame
    void Update()
    {
        scoreText.text =  "Score:" + score.ToString("D4");
    }
}
