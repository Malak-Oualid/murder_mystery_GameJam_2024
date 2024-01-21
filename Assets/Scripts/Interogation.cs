using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interogation : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Player;
    public bool inrange = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the entering object is the player
        if (other.gameObject == Player)
        {
            
            inrange = true;
            // Debug.Log("in");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            inrange = false;
            // Debug.Log("out");
        }

    }
    void Update()
    {
        if (inrange==true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("CafeBar");
            // Debug.Log("switchscene");
        }
    }
}
