using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    // represented via variable and not directly because we need to limit the 
    float xRotation = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // hide and lock cursor to middle of screen
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // time.deltatime is time gone by since last time update was called,
        // multiply by this to have mov independent off frame rate
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        xRotation -= mouseY; // increasing would be flipped, therefore decreasing
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // limit rotation on x axis
        
        // transforms the rotation (Quaternions used for internal rotation rep. without gimbal lock!)
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
