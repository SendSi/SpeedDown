using System;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        anim = this.GetComponent<Animator>();
    }

    public float speed;
    private float xVelocity;

    private void Update()
    {
        Movement();
    }

    void Movement()
    {
        xVelocity = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);
        if (xVelocity!=0)
        {
            transform.localScale = new Vector3(xVelocity*3f, 3f, 3f);
        }
    }
}