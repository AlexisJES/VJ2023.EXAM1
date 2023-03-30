using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer sr;
    private int currentAnimation = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentAnimation = 1;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(5, rb.velocity.y);
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            currentAnimation = 2;
            rb.velocity = new Vector2(-5, rb.velocity.y);
            sr.flipX = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            currentAnimation = 3;
            rb.velocity = new Vector2(-5, rb.velocity.y);
            sr.flipX = true;
        }

        if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            currentAnimation = 3;
            rb.velocity = new Vector2(5, rb.velocity.y);
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.X))
        {
            currentAnimation = 4;
        }

        anim.SetInteger("Ninja", currentAnimation);

    }
}
