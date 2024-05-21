/*
* Author: Isaac
* Date: 19 may
* Description: increase the score when you have collected a collectable
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public TextMeshProUGUI scoretext;

    private int currentscore = 0; // Made private to encapsulate the score

    public void IncreaseScore(int scoretoadd)
    {
        currentscore += scoretoadd;

        scoretext.text = currentscore.ToString();
        Debug.Log(currentscore);
    }

    // Public method to get the current score
    public int GetCurrentScore()
    {
        return currentscore;
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
