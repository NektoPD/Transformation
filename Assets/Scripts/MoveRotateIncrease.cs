using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRotateIncrease : MonoBehaviour
{
    private Vector3 _scaleSize = new Vector3(0.001f, 0.001f, 0.001f);
    private float _moveSpeedIncrease = 0.001f;
    private float _rotateAngle = 10;

    void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeedIncrease);
        transform.Rotate(0, _rotateAngle * Time.deltaTime,0);
        transform.localScale += _scaleSize;   
    }
}
