using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Vector3 = UnityEngine.Vector3;


public class EnemyManager : MonoBehaviour
{
    float lookRange = 10f;
    
    public NavMeshAgent agent;  //is attached to a mobile character in the game to allow it to navigate the Scene
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = PlayerManager.instance.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
