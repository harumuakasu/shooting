using System.Collections;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIContller : MonoBehaviour
{

    public static UIContller Instance;
    private int score = 0;
    //[SerializeField]TextMeshProUGUI scoreText;
    [SerializeField]TextMeshProUGUI gameOverText;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

     public void AddScore()
     {
         this.score += 10;
         //scoreText.text =  "Score:" + score.ToString("D4");
     }

     public int GetScore()
     {
         return score;
     }
     
     public void GameOver()
     {
         Instantiate(gameOverText);
         Debug.Log("GameOver");
     }

    // Update is called once per frame
}
