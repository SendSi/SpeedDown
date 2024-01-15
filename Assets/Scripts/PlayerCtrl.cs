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
    public bool isOnGround;

    public LayerMask platform;
    public GameObject groundCheck;
    public float checkRadius;

    private void Update()
    {
        isOnGround = Physics2D.OverlapCircle(groundCheck.transform.position, checkRadius, platform);
        Movement();
    }

    void Movement()
    {
        xVelocity = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(xVelocity * speed, rb.velocity.y);
        anim.SetFloat("speed",Mathf.Abs(rb.velocity.x));//跑动
        if (xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity * 3f, 3f, 3f);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color=Color.blue;
        Gizmos.DrawWireSphere(groundCheck.transform.position,checkRadius);
    }
}