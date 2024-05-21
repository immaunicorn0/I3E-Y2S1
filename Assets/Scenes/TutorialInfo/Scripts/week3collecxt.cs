using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class week3collecxt : MonoBehaviour
{
    // Start is called before the first frame update
    void collected()
    {
        Debug.Log(gameObject.name + "I got colilided with");
        Destroy(gameObject);
    }
    void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.tag == "player")
        {
            collected();
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
