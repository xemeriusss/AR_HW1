using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    // This variable will hold a reference to the GameObject you want to toggle
    public GameObject targetObject;

    public void OnButtonClick()
    {
        // Toggle the active state of the target object
        if (targetObject != null)
        {
            targetObject.SetActive(!targetObject.activeSelf);
            Debug.Log($"{targetObject.name} is now {(targetObject.activeSelf ? "active" : "inactive")}");
        }
        else
        {
            Debug.LogWarning("Target object is not assigned!");
        }
    }
}
