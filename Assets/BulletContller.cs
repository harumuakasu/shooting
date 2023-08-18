using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private UIContller _uiContller;
    
    
    void Update()
    {
        //打った球を消す
        transform.Translate(0,0.1f,0);

        if (transform.position.y > 5)
        {
            Destroy((gameObject));
        }
    }

    
}
