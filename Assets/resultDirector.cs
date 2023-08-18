using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resultDirector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI ScoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GManager.Instance.score);
        ScoreText.text = GManager.Instance.score.ToString("d4");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("OutGameScene");
        }
    }
}
