using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;

public class enemyContller : MonoBehaviour
{
     float fallSpeed;
     float rotSpeed;

     //[SerializeField] private UIContller Contller;
     
    void Start()
    {
        this.fallSpeed = 0.001f + 0.001f * Random.value;
        this.rotSpeed = 5f + 3f * Random.value;
        
    }

    
    void Update()
    {
        transform.Translate(0,-fallSpeed,0,Space.World);
        transform.Rotate(0,0,rotSpeed);

        if (transform.position.y < -5.5f)
        {
            
            //UIContller.Instance().GameOver();
            //Destroy(gameObject);
        }
    }
}
