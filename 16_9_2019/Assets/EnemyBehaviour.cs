using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour
{
    Vector2 pos;
    float speed = 0.01f;
    SpriteRenderer myspriteRenderer;
    // Start is called before the first frame update
    float limitLeft = 6.5f;
    float limitRight = 11.5f;
    void Start()
    {
        pos = transform.position;
        myspriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        pos.x += CheckStateDirect() * speed;
        transform.position = pos;
    }

    private int CheckStateDirect()
    {
        if (pos.x > limitLeft && myspriteRenderer.flipX == false)
            return -1;
        if (pos.x < limitRight && myspriteRenderer.flipX == true)
            return 1;
        if (pos.x <= limitLeft && myspriteRenderer.flipX == false)
        {
            myspriteRenderer.flipX = true;
            return 1;
        }
        if (pos.x >=limitRight && myspriteRenderer.flipX == true)
        {
            myspriteRenderer.flipX = false;
            return -1;
        }
        return 0;
    }
}
