using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private Rigidbody2D playerRB;
    [SerializeField] private Animator animator;

    public Vector2 MoveDirection;
    private void Update()
    {

        InputDetect();
        SetAnimations();

    }

    private void FixedUpdate()
    {

        Move();
    }

    private void InputDetect()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");
        MoveDirection = new Vector2(dirX, dirY).normalized;
    }

    private void SetAnimations()
    {
        animator.SetFloat("Horizontal", MoveDirection.x);
        animator.SetFloat("Vertical", MoveDirection.y);
        animator.SetFloat("MovementSpeed", MoveDirection.magnitude);
    }

    private void Move()
    {
        playerRB.MovePosition(playerRB.position + MoveDirection * movementSpeed * Time.fixedDeltaTime);
    }
}
