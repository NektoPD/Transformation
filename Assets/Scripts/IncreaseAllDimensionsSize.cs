using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    [SerializeField] private float _speed;


    void Update()
    {
        Vector3 scaleChange = new Vector3(_speed * Time.deltaTime, _speed * Time.deltaTime, _speed * Time.deltaTime);

        transform.localScale += scaleChange;
    }
}
