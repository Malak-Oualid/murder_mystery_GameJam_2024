using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goupstair : MonoBehaviour
{

    public GameObject Player;
    public bool instair_down = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entering object is the player
        if (other.gameObject == Player)
        {
            
            instair_down = true;
            // Debug.Log("in");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            instair_down = false;
            // Debug.Log("out");
        }

    }
    void Update()
    {
        if (instair_down==true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Bedroom");
            // Debug.Log("switchscene");
        }
    }
    
}
