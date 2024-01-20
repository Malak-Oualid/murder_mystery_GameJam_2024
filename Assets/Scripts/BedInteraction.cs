using UnityEngine;
using UnityEngine.UI;

public class BedInteractionScript : MonoBehaviour
{
    public Text popupText;  // Reference to the Text component for displaying the pop-up message

    private bool isPlayerInRange = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = true;
            popupText.text = "Press 'E' to interact with the bed";
            popupText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerInRange = false;
            popupText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (isPlayerInRange && Input.GetKeyDown(KeyCode.E))
        {
            // Implement your interaction logic here
            ShowPopup("You interacted with the bed!");
        }
    }

    private void ShowPopup(string message)
    {
        // You can customize the pop-up appearance here
        Debug.Log(message);
    }
}
