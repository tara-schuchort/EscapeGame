using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        Vector3 doorOpening = new Vector3(
            0,
            0,
            0.1f);
        transform.Translate(doorOpening);
    }
}
