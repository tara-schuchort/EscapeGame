using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Transform player;
    public Transform door;
    public float threshhold; 
    private bool door_active; 

    // Start is called before the first frame update
    void Start()
    {
     
      door_active = false; 
      player = GameObject.Find("Player").transform; 
      door = GameObject.Find("Door").transform; 
    }

    // Update is called once per frame
    void Update()
    {


        

        
        var dist = Vector3.Distance(player.position,door.position );

        if (dist <= threshhold){
                //dosth

                Debug.Log("true");

        }
    }
}
