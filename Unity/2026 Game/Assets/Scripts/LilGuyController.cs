using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LilGuyController : MonoBehaviour
{
    public float speed = 5f;
    private Vector2 movement;

    private void Update()
    {
        // GetAxisRaw() is exactly -1 or +1
        // GetAxis() uses the decimals in between (Good for acceleration)
        // Mapping the axis for keycodes and buttons
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
    }
}