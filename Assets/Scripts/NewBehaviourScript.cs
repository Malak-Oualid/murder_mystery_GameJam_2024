using System.Collections;
using TMPro;
using UnityEngine;

public class GradualTextDisplay : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string fullText;
    public float revealSpeed = 0.05f;

    void Start()
    {
        StartCoroutine(RevealText());
    }

    IEnumerator RevealText()
    {
        int characterIndex = 0;

        while (characterIndex < fullText.Length)
        {
            textComponent.text += fullText[characterIndex];
            characterIndex++;

            yield return new WaitForSeconds(revealSpeed);
        }
    }
}
