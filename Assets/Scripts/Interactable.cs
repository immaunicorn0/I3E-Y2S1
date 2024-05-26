/*
 * Author: Elyas Chua-Aziz
 * Date: 20/05/2024
 * Description: 
 * Contains functions related to the Interactable
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Stores the current player that can interact with the object
    protected Player currentPlayer;

    // Method to increase player's movement speed
    protected void IncreaseMovementSpeed(float speedIncrease)
    {
        var playerController = currentPlayer.GetComponent<FirstPersonController>();
        if (playerController != null)
        {
            playerController.MoveSpeed += speedIncrease;
        }
    }

    // Method to increase player's jump height
    protected void IncreaseJumpHeight(float jumpHeightIncrease)
    {
        var playerController = currentPlayer.GetComponent<FirstPersonController>();
        if (playerController != null)
        {
            playerController.JumpHeight += jumpHeightIncrease;
        }
    }

    // Update the player's Interactable
    public void UpdatePlayerInteractable(Player thePlayer)
    {
        thePlayer.UpdateInteractable(this);
    }

    // Remove the player's Interactable
    public void RemovePlayerInteractable(Player thePlayer)
    {
        thePlayer.UpdateInteractable(null);
    }

    // Execute the object's interaction
    public virtual void Interact(Player thePlayer)
    {
        Debug.Log(gameObject.name + " was interacted with.");
    }
}