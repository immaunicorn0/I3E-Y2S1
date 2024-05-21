/*
* Author:Isaac
* Date:19 may
* Description:the collectable code
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    int myScore = 5;
    bool isCollected = false;
    string myName = "current score:";



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("touch");
            other.gameObject.GetComponent<Player>().IncreaseScore(myScore);
            Collected();

        }
    }


    void Collected()
    {
        Debug.Log(gameObject.name + "item has been collected");
        Destroy(gameObject);
    }

    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {

    }
}