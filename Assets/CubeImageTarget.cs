using UnityEngine;
using Vuforia;

public class CubeImageTarget : MonoBehaviour
{
    private ObserverBehaviour observerBehaviour;

    void Start()
    {
        observerBehaviour = GetComponent<ObserverBehaviour>();
        if (observerBehaviour)
        {
            observerBehaviour.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    private void OnTargetStatusChanged(ObserverBehaviour observer, TargetStatus targetStatus)
    {
        Debug.Log("Tracking status changed: " + targetStatus.Status);

        if (targetStatus.Status == Status.TRACKED && targetStatus.StatusInfo == StatusInfo.NORMAL)
        {
            // Show the object when the target is tracked
            gameObject.SetActive(true);
            Debug.Log("Object shown.");
        }
        else
        {
            // Hide the object when the target is lost
            gameObject.SetActive(false);
            Debug.Log("Object hidden.");
        }
    }

}
