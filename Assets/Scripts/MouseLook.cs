using UnityEngine;
using Cursor = UnityEngine.Cursor;

public class MouseLook : MonoBehaviour
{
    // determines in-game mouse sensitivity (could be user input!)
    public float mouseSensitivity = 500f;

    public Transform playerBody;

    //xRotation rotates around x-axis (up and down) and y rotation around y-axis (left and right), standard is 0
    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        // locks cursor to center of game window and hides it
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // get mouse axis input, apply mouse sensitivity and multiply by Time.deltaTime for frame independence
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // camera moves in direction the mouse moves (change -/+ to invert this)
        xRotation -= mouseY;
        yRotation += mouseX;
        // min-90 to max90 means full rotation, so up/down is limited to 180°
        xRotation = Mathf.Clamp(xRotation, -45f, 45f);
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);
        
        // 
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
