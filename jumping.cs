using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
    [SerializeField] // This will make the variable below appear in the inspector
    float speed = 6;

    [SerializeField]
    float jumpSpeed = 8;

    [SerializeField]
    float gravity = 20;

    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;

    [SerializeField]
    int nrOfAlowedDJumps = 1; // New vairable
    int dJumpCounter = 0;     // New variable

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        moveDirection.x = Input.GetAxis("Horizontal") * speed;
        moveDirection.z = Input.GetAxis("Vertical") * speed;

        if (Input.GetButtonDown("Jump"))
        {
            if (controller.isGrounded)
            {
                moveDirection.y = jumpSpeed;
                dJumpCounter = 0;
            }
            if (!controller.isGrounded && dJumpCounter < nrOfAlowedDJumps)
            {
                moveDirection.y = jumpSpeed + 5;
                dJumpCounter++;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}