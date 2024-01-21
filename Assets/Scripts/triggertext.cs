using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertext : MonoBehaviour
{
    public GameObject Player;

    // Text to display
    public string displayText = "Player entered the box!";

    // This function is called when something enters the collider of the box object
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entering object is the player
        if (other.gameObject == Player)
        {
            // Display the text or perform any other actions
            DisplayText(displayText);
        }
    }

    // Function to display the text
    private void DisplayText(string text)
    {
        // Implement code to display the text on the screen or in the game
        Debug.Log("uwu");
    }

}
