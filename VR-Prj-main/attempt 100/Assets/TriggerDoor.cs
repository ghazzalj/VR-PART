using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour

{

    BasicDoorController door;
    public GameObject d;
   // public GameObject d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "book")
        {
            Debug.Log("Triggered by book");
            door = GameObject.Find("Basic_RaycastDoor").GetComponentInChildren<BasicDoorController>();
               
          

            door.PlayAnimation();
        }
    }
}
