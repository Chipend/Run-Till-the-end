using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text;

public class TypingText : MonoBehaviour
{
    public Text textComponent;
    public float typingSpeed;
    public string textToType;

    private StringBuilder stringBuilder;

    void Start()
    {
        stringBuilder = new StringBuilder();
        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        foreach (char letter in textToType)
        {
            stringBuilder.Append(letter);
            textComponent.text = stringBuilder.ToString();
            yield return new WaitForSeconds(typingSpeed);
        }
    }
}