using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController charController;

    public float speed = 12f;
        
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // new Vector3(x, 0f, z) would be global and moves in same direction no matter where u face therefore:
        Vector3 move = transform.right * x + transform.forward * z;
        
        // dont move along z axis
        Vector3 pos = this.transform.position;
        pos.z = 0;
        this.transform.position = pos;

        charController.Move(move * speed * Time.deltaTime);
    }
}
