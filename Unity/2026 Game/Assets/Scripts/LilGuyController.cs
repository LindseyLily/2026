using UnityEngine;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(CharacterController))]
    
public class LilGuyController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;

    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        KeepCharacterOnxAxis();
    }

    private void MoveCharacter()
    {
        //Horizontal movement
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(x: moveInput, y: 0f, z: 0f) * (moveSpeed * Time.deltaTime);
        controller.Move(move);
    }

    private void KeepCharacterOnxAxis()
    {
        // Prevents character from moving on the z axis
        var currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}

