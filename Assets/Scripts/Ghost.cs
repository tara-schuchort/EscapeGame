using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{

    private float lookRange = 10f;

    public UnityEngine.AI.NavMeshAgent agent;  //is attached to a mobile character in the game to allow it to navigate the Scene
    
    private Transform target;
    private PlayerController playerInst;

    // Start is called before the first frame update
    void Start()
    {

        playerInst = PlayerController.Instance;
        target = playerInst.transform;


        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
       
    }

    // Update is called once per frame
    void Update()
    {

        Chasing(target);
    }


    public void Chasing(Transform target)
    {


        Debug.Log(target.position);
        Debug.Log(this.transform.position);

        var distance = Vector3.Distance(target.position,this.transform.position);

        // if enemy can see the player, start chase
        if (distance <= lookRange)
        {
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                //attack the target

                FaceTarget();
            }
        }
    }

    public void FaceTarget()
    {
        // get direction where to face
        Vector3 direction = (target.position - transform.position).normalized;
        // get rotation to that direction
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        // update own position
        transform.rotation = lookRotation;  // could smooth this with Quaternion.Slerp(transform.rotation, lookRotation, time.deltaTime * 5f);
    }


}
