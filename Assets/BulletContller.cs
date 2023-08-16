using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private UIContller _uiContller;
    
    //[SerializeField] private UIContller Contller;
    
    
    void Update()
    {
        transform.Translate(0,0.1f,0);

        if (transform.position.y > 5)
        {
            Destroy((gameObject));
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(coll.gameObject);
        Destroy((gameObject));
         UIContller.Instance.AddScore();
         
    }
}
