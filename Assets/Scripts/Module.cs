using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Module : MonoBehaviour
{
    private bool _state;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GetPlace(GetMousePos()))
            {
                if (!_state)
                {
                    _state = true;
                    GetComponent<SpriteRenderer>().color = Color.green; // временный код
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (_state)
        {
            // jump
        }
    }

    bool GetPlace(Vector2 pos)
    {
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 1f);
        
        if (!hit.collider) return false;
        if (hit.collider.gameObject == this.gameObject)
            return true;
        return false;
    }

    Vector2 GetMousePos()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
