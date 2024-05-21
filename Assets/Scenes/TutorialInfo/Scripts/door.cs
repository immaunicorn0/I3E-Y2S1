
/*
* Author:Isaac 
* Date:19 may
* Description: the dooe code so that the door opens on contact
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    bool opened = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Check if gameObject enter & if it is player(tag)
        if(other.gameObject.tag == "Player" && !opened)   
        {
            //Open Door
         OpenDoor();
        }
    }
    void OpenDoor()
    {     //code for open door
        Vector3 newRotation = transform.eulerAngles;newRotation.y += 90f;transform.eulerAngles = newRotation;
        opened = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
