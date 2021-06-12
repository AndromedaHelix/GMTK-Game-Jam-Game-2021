using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Controls controls;

    public Rigidbody2D[] rb;
    public float movementSpeed;

    float moveDirectionX;

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
        ProcessInputs();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        //Implement Jump
    }

    void Move()
    {
        foreach (var rigidbody in rb)
        {
            rigidbody.velocity = new Vector2(moveDirectionX * movementSpeed, rigidbody.velocity.y);
        } 
    }
}
