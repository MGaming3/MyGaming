using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6f;
    public float gravity = 20f;

    public float jump = 5f;

    CharacterController controller;

    Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), .0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jump;
            }




        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 12f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 6f;
        }
        
            moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

    }
}
