using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip2 : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // if the variable isn't empty (we have a reference to our SpriteRenderer
            if (mySpriteRenderer != null)
            {
                // flip the sprite
                mySpriteRenderer.flipX = true;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // flip the sprite
            mySpriteRenderer.flipX = false;
        }
    }
}