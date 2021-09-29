using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    public GameObject ghostPrefab;



    private bool main_door_key;
    private bool sliding_door_key;
    private int garlic;
    private bool demon_defeated;


    //[SerializeField] private GameObject _slidingDoor;
    // Start is called before the first frame update
    void Awake()
    {
        main_door_key = false;
        sliding_door_key = false;
        garlic = 0;
        demon_defeated = false;
        //_slidingDoor.GetComponent<SlidingDoor>().OpenDoor();
    }

    void Start()
    {
      //  SpawnGhosts(ghostPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnGhosts(GameObject ghostPrefab)
    {
        Vector3 pos = Vector3.zero;
        Quaternion rot = UnityEngine.Random.rotation;
        Ghost newGhost = Instantiate(ghostPrefab, pos, rot).GetComponent<Ghost>();
    }


}
