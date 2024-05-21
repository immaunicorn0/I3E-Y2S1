/*
* Author: Isaac
* Date:19 may
* Description: updates the score
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class objectnum : MonoBehaviour
{
    public TextMeshProUGUI scoretext;
    public Player player; // Reference to the Player script

    // Start is called before the first frame update
    void Start()
    {
        // If the player reference is not set in the Inspector, try to find it
        if (player == null)
        {
            player = FindObjectOfType<Player>();
        }

        // Ensure player is found
        if (player == null)
        {
            Debug.LogError("Player script not found. Please assign the Player script in the Inspector.");
            return;
        }

        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        // Ensure player is set before updating the score text
        if (player != null)
        {
            UpdateScoreText();
        }
    }

    void UpdateScoreText()
    {
        // Ensure player is set
        if (player == null)
        {
            Debug.LogError("Player script not set. Cannot update score text.");
            return;
        }

        int currentscore = player.GetCurrentScore(); // Use the new public method

        if (currentscore == 0)
        {
            scoretext.text = "You have 9 items left";
        }
        else if (currentscore == 5)
        {
            scoretext.text = "You have 8 more items to collect";
        }
        else
        {
            scoretext.text = $"You have {9 - currentscore/5} items left";
        }
        if (currentscore==45)
        {
            scoretext.text = "Congratulations! You collected all items!";
        }
    }
}

