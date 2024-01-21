using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggertext : MonoBehaviour
{

    public GameObject uiObject;
    //void Start()
    //{
    //    uiObject.SetActive(false);
    //}
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Y))
        {
            uiObject.SetActive(true);
            StartCoroutine("WaitForSec");
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiObject);
        Destroy(gameObject);
    }

}