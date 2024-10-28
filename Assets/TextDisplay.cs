using UnityEngine;
using TMPro;

public class TextDisplay : MonoBehaviour
{
    public TextMeshPro textObject;
    public string message = "Welcome to AR!";

    void Start()
    {
        textObject.text = message;
        textObject.gameObject.SetActive(false);
    }

    void OnTrackingFound()
    {
        textObject.gameObject.SetActive(true);
    }

    void OnTrackingLost()
    {
        textObject.gameObject.SetActive(false);
    }

    // This method resets the text when switching tasks
    public void ResetText()
    {
        textObject.gameObject.SetActive(false); // Ensure text is hidden when switching
    }
}
