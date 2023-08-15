using System.Collections;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIContller : MonoBehaviour
{

    public static UIContller Instance;
    private int score = 0;
    [SerializeField]TextMeshProUGUI scoreText;
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
     }
     public void GameOver()
     {
         gameOverText.text = "GameOver";
         Debug.Log("GameOver");
     }

    // Update is called once per frame
    void Update()
    {
        scoreText.text =  "Score:" + score.ToString("D4");
    }
}
