using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class image : MonoBehaviour
{
    public Player player; // Reference to the Player script
    public TextMeshProUGUI scoretext; // Reference to the TextMeshProUGUI component for the score
    public GameObject congratsImage; // Reference to the congratulatory image GameObject
    public TextMeshProUGUI congratsText; // Reference to the TextMeshProUGUI component for the congratulatory message

    private int totalItems = 9; // Total number of items to collect

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

        // Initially hide the congratulatory image and text
        if (congratsImage != null)
        {
            congratsImage.SetActive(false);
        }
        if (congratsText != null)
        {
            congratsText.gameObject.SetActive(false);
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

        int currentscore = player.GetCurrentScore(); // Use the public method

        if (currentscore >= totalItems)
        {
            scoretext.text = "Congratulations! You have collected all items!";
            if (congratsImage != null)
            {
                congratsImage.SetActive(true); // Show the congratulatory image
            }
            if (congratsText != null)
            {
                congratsText.gameObject.SetActive(true); // Show the congratulatory message
                congratsText.text = "Congratulations! You collected all items!"; // Set the congratulatory text
            }
        }
        else
        {
            scoretext.text = $"You have {totalItems - currentscore} items left";
            // Ensure the congratulatory image and text are hidden if not all items are collected
            if (congratsImage != null)
            {
                congratsImage.SetActive(false);
            }
            if (congratsText != null)
            {
                congratsText.gameObject.SetActive(false);
            }
        }
    }
}
