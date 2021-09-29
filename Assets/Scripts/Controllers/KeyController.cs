using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{

    public static KeyController Instance; 

    public bool taken { get; set; }
    MeshRenderer mr;

    void Awake()
    {
        Instance = this;

        mr = GetComponent<MeshRenderer>();
        taken = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var dist_to_key = Vector3.Distance();
       // if ((Input.GetKeyDown(KeyCode.E)))
        if (taken)
        {

            mr.material.EnableKeyword("_EMISSION");

        }
    }
}
