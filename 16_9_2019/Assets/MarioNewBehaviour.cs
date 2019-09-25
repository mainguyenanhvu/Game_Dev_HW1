using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioNewBehaviour : MonoBehaviour
{
    float speed = 0.1f;
    Vector2 pos;
    SpriteRenderer myspriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        myspriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (myspriteRenderer.flipX == true)
            {
                myspriteRenderer.flipX = false;
            }
            pos.x -= speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (myspriteRenderer.flipX == false)
            {
                myspriteRenderer.flipX = true;
            }
            pos.x += speed;
        }
        transform.position = pos;
    }
}
