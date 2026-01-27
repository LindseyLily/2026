using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody2D;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private float jumpForce = 6;
    private float playerHalfHeight;

    private void Start()
    {
        playerHalfHeight = spriteRenderer.bounds.extents.y;
    }
    
    void Update()
    {
        
        Debug.DrawRay(transform.position, Vector2.down * (playerHalfHeight + 0.1f), Color.red);
        
       if (Input.GetKeyDown(KeyCode.Space) && GetIsGrounded())
        {
            Jump();
        }
    }

    private bool GetIsGrounded()
    {
       return Physics2D.Raycast(transform.position, Vector2.down, playerHalfHeight + 0.1f, LayerMask.GetMask("Ground")); 
    }
    private void Jump()
    {
        rigidBody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
