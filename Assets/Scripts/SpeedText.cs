using System.Collections;
using TMPro;
using UnityEngine;

public class SpeedText : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string fullText;
    public float revealSpeed = 0.05f;
    public float displayTime = 2f; // Adjust this value to set how long the text should be displayed after full reveal

    void Start()
    {
        StartCoroutine(RevealAndDisappearText());
    }

    IEnumerator RevealAndDisappearText()
    {
        int characterIndex = 0;

        while (characterIndex < fullText.Length)
        {
            textComponent.text += fullText[characterIndex];
            characterIndex++;

            yield return new WaitForSeconds(revealSpeed);
        }

        // Wait for the specified display time
        yield return new WaitForSeconds(displayTime);

        // Clear the text
        textComponent.text = string.Empty;
    }
}
