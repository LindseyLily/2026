using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour
{
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
  Rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
 }
}
