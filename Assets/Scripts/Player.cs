using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _speed = 5f;


    private void Update()
    {
        transform.position += (Vector3) Vector2.right * (Time.deltaTime * _speed);
    }
}
