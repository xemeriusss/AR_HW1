using UnityEngine;

public class MultiButtonHandler : MonoBehaviour
{
    // Create an array size 3 to store GameObjects
    public GameObject[] targetObjects;

    public void OnButtonClick()
    {
        // Toggle the active state of each target object
        foreach (GameObject targetObject in targetObjects)
        {
            if (targetObject != null)
            {
                targetObject.SetActive(!targetObject.activeSelf);
                Debug.Log($"{targetObject.name} is now {(targetObject.activeSelf ? "active" : "inactive")}");
            }
            else
            {
                Debug.LogWarning("One of the target objects is not assigned!");
            }
        }
    }
}
