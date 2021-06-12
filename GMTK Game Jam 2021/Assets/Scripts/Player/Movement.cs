using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Controls controls;

    public float movementSpeed;
    public float jumpHeight;
    float moveDirectionX;

    public Rigidbody2D rb;

    bool facingRight = true;

    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask groundMask;
    bool isGrounded;




    #region Input System
    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private bool isJumping()
    {
        return controls.Player.Jumping.triggered;
    }
    #endregion

    void Update()
    {
        moveDirectionX = controls.Player.Movement.ReadValue<float>();

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, groundMask);

        bool jumpingPressed = isJumping();
        if(isGrounded && jumpingPressed)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpHeight);
        }

        if(!facingRight && moveDirectionX > 0f)
        {
            flip();
        }
        else if(facingRight && moveDirectionX < 0f)
        {
            flip();
        }

        jump();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirectionX * movementSpeed, rb.velocity.y);
    }

    void jump()
    {

    }

    void flip()
    {
        facingRight = !facingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
