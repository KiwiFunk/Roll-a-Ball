using System;
using UnityEngine; 
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;

    private Rigidbody rigidBody;
    private float movementX;
    private float movementY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Assign the Rigidbody component to the rigidBody variable
        rigidBody = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        Vector3 movementVector = new Vector3(movementX, 0.0f, movementY);
        // Apply force to RigidBody using movement vector * speed
        rigidBody.AddForce(movementVector * speed);
        
    }

    void OnMove(InputValue movementValue)
    {
        // Get vector from movementValue and store it in variable
        Vector2 movementVector = movementValue.Get<Vector2>();
        // Assign the x and y components of the movement vector to the movementX and movementY variables
        movementX = movementVector.x;
        movementY = movementVector.y;

    }
    
}

