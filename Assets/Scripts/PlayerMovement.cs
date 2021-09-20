using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController charController;
    // variables according to motion (movement speed of the player, falling velocity if not grounded and gravity)
    public float mov_speed = 12f;
    public float gravity = 9.8f;
    public float velocity = 0f;

    void Start()
    {
        charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal_mov = Input.GetAxis("Horizontal") * mov_speed; //x
        float vertical_mov = Input.GetAxis("Vertical") * mov_speed; //z

        // new Vector3(x, 0f, z) would be global and moves in same direction no matter where u face therefore:
        Vector3 move = transform.right * horizontal_mov + transform.forward * vertical_mov;

        // move the player by the direction (speed already applied) times Time.deltaTime for frame independence
        charController.Move(move * Time.deltaTime);
        
        // Gravity mechanic: if player isn't grounded  falls (y-axis) with a velocity influenced by the time & gravity
        if (!charController.isGrounded)
        {
            velocity -= gravity * Time.deltaTime;
            charController.Move(new Vector3(0, velocity, 0));
        }
    }
}