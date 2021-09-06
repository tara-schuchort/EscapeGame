using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    //NavMeshAgent agent;
    [SerializeField] public Animator ani;
    [SerializeField] private float walk_speed;
    private bool walk;
    void Start()
    {
        //agent = GetComponent<NavMeshAgent>();
        walk = true;
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collide: " + other);
        walk = false;

    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("no collide: " + other);
        walk = true;

    }


    void PlayerMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        if (walk)
        {
            if ((verticalInput != 0) || (horizontalInput != 0))
            {
                ani.SetInteger("legs", 1);
            }
            else
            {
                ani.SetInteger("legs", 0);
            }

            if (verticalInput != 0)
            {
                ani.SetInteger("arms", 1);
            }
            else
            {
                ani.SetInteger("arms", 0);
            }


            Vector3 playerTranslate = new Vector3(
                0,
                0,
                verticalInput * walk_speed);
            transform.Translate(playerTranslate);
        } 
        else 
        {
            Vector3 playerTranslate = new Vector3(
                0,
                0,
                - verticalInput * walk_speed * 2);
            transform.Translate(playerTranslate);
        }


        transform.Rotate(new Vector3(0f, 10f, 0f) * horizontalInput * walk_speed, Space.World);
      

        
    }
    void Update()
    {
        

        PlayerMovement();
    }
}


















