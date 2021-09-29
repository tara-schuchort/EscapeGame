using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController _charController;
    // variables according to motion (movement speed of the player, falling velocity if not grounded and gravity)
    public float movSpeed = 12f;
    public float gravity = 9.8f;
    public float velocity = 0f;

    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMov = Input.GetAxis("Horizontal") * movSpeed; //x
        float verticalMov = Input.GetAxis("Vertical") * movSpeed; //z

        // new Vector3(x, 0f, z) would be global and moves in same direction no matter where u face therefore:
        Vector3 move = transform.right * horizontalMov + transform.forward * verticalMov;

        // move the player by the direction (speed already applied) times Time.deltaTime for frame independence
        _charController.Move(move * Time.deltaTime);
        
        // Gravity mechanic: if player isn't grounded  falls (y-axis) with a velocity influenced by the time & gravity
        if (!_charController.isGrounded)
        {
            velocity -= gravity * Time.deltaTime;
            _charController.Move(new Vector3(0, velocity, 0));
        }
    }
}