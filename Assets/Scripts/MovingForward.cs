using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    private float _speed = 2;
    
    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime,0,0);
    }
}
