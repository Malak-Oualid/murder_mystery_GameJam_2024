using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Godownstair : MonoBehaviour
{

    public GameObject Player;
    public bool instair = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entering object is the player
        if (other.gameObject == Player)
        {
            
            instair = true;
            // Debug.Log("in");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            instair = false;
            // Debug.Log("out");
        }

    }
    void Update()
    {
        if (instair==true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Cafe");
            // Debug.Log("switchscene");
        }
    }
    
}
