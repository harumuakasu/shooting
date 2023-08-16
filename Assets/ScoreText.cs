using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class ScoreText:MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;

        void Update()
        {
            
            scoreText.text = "Score:" + UIContller.Instance.GetScore().ToString("D4");

        }
    }
}