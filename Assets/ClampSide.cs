using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClampSide : MonoBehaviour
{
    // x軸方向の移動範囲の最小値
    [SerializeField] private float _minX; 

    // x軸方向の移動範囲の最大値
    [SerializeField] private float _maxX;

    private void Update()
    {
        var pos = transform.position;

        // x軸方向の移動範囲制限
        pos.x = Mathf.Clamp(pos.x, _minX, _maxX);

        transform.position = pos;
    }
}