using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidBody2D;
    [SerializeField] private float jumpForce = 6;
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump()
    {
        rigidBody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
