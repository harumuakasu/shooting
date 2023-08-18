using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class enemyContller : MonoBehaviour
{
     float fallSpeed;
     float rotSpeed;

     //[SerializeField] private UIContller Contller;
     private bool isfinished; 
     
    void Start()
    {
        this.fallSpeed = 0.001f + 0.001f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
        isfinished = false;
    }

    
    void Update()
    {
        transform.Translate(0,-fallSpeed,0,Space.World);
        transform.Rotate(0,0,rotSpeed);
        
        
        if (transform.position.y < -7.5f)
        {
            if (!isfinished)
            {
                GManager.Instance.score = UIContller.Instance.GetScore();
                UIContller.Instance.GameOver();
                Debug.Log(GManager.Instance.score);
                Destroy(gameObject);
                isfinished = true;
                _PlayerPopAsync().Forget();
            }
            
        }
    }
    
    private void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log(coll.gameObject.name);
        if (coll.gameObject.name == "Player")
        {
            //ゲームオーバ処理を書く
            Destroy(coll.gameObject);
            Destroy(gameObject);
            UIContller.Instance.GameOver();
            _PlayerPopAsync().Forget();
            
        }
        
        else if (coll.gameObject.name == "Bullet(Clone)")
        {
            //球に当たったら敵が消える処理
            Destroy(coll.gameObject);
            Destroy(gameObject);
            UIContller.Instance.AddScore();
        }
        
        
    }
    
    private async UniTask _PlayerPopAsync()
    {
        await UniTask.Delay(TimeSpan.FromSeconds(3));
        
        SceneManager.LoadScene("resultGameScene");
        Debug.Log("gameover");
        
    }
    
}


    