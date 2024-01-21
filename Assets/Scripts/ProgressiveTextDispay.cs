using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ProgressiveTextDisplay : MonoBehaviour
{
    public Text uiText;
    public string displayText;
    public float delayBetweenCharacters = 0.1f;

    void Start()
    {
        // Start the coroutine to display text progressively
        StartCoroutine(DisplayTextProgressively());
    }

    IEnumerator DisplayTextProgressively()
    {
        // Iterate through each character in the displayText
        for (int i = 0; i < displayText.Length; i++)
        {
            // Get the substring up to the current character
            string partialText = displayText.Substring(0, i + 1);

            // Assign the partial text to the UI Text component
            uiText.text = partialText;

            // Wait for a short delay before displaying the next character
            yield return new WaitForSeconds(delayBetweenCharacters);
        }
    }
}
