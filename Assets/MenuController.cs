using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video; // Add this to handle the Video Player

public class MenuController : MonoBehaviour
{
    public Button stationaryObjectButton;
    public Button animatedObjectButton;
    public Button movingObjectButton;
    public Button interactionButton;
    public Button textObjectButton;
    public Button videoButton; // Button to play video
    public Button imageButton; // Button to display image

    public GameObject stationaryObject;
    public GameObject animatedObject;
    public GameObject movingObject;
    public GameObject interactionObject1;
    public GameObject interactionObject2;
    public GameObject interactionObject3;
    public GameObject textObject;

    public GameObject videoPlayerObject; // Reference to the Video Player GameObject
    private VideoPlayer videoPlayer; // Reference to the Video Player component

    public GameObject imageObject; // Reference to the Image GameObject

    void Start()
    {
        DisableAllObjects();

        // Initialize Video Player
        videoPlayer = videoPlayerObject.GetComponent<VideoPlayer>();

        // Add listeners for buttons
        stationaryObjectButton.onClick.AddListener(() => SelectStationaryObject());
        animatedObjectButton.onClick.AddListener(() => SelectAnimatedObject());
        movingObjectButton.onClick.AddListener(() => SelectMovingObject());
        interactionButton.onClick.AddListener(() => SelectInteractionObject());
        textObjectButton.onClick.AddListener(() => SelectTextObject());
        videoButton.onClick.AddListener(() => PlayVideo()); // Listener for the video button
        imageButton.onClick.AddListener(() => DisplayImage()); // Listener for the image button
    }

    void DisableAllObjects()
    {
        stationaryObject.SetActive(false);
        animatedObject.SetActive(false);
        movingObject.SetActive(false);
        interactionObject1.SetActive(false);
        interactionObject2.SetActive(false);
        interactionObject3.SetActive(false);
        textObject.SetActive(false);
        videoPlayerObject.SetActive(false); // Hide video player by default
        imageObject.SetActive(false); // Hide image by default
    }

    void SelectStationaryObject()
    {
        DisableAllObjects();
        stationaryObject.SetActive(true);
    }

    void SelectAnimatedObject()
    {
        DisableAllObjects();
        animatedObject.SetActive(true);
    }

    void SelectMovingObject()
    {
        DisableAllObjects();
        movingObject.SetActive(true);
    }

    void SelectInteractionObject()
    {
        DisableAllObjects();
        interactionObject1.SetActive(true);
        interactionObject2.SetActive(true);
        interactionObject3.SetActive(true);
    }

    void SelectTextObject()
    {
        DisableAllObjects();
        textObject.SetActive(true);
    }

    void PlayVideo()
    {
        DisableAllObjects(); // Disable all other objects
        videoPlayerObject.SetActive(true); // Show the video player
        videoPlayer.Play(); // Start playing the video
    }

    void DisplayImage()
    {
        DisableAllObjects(); // Disable all other objects
        imageObject.SetActive(true); // Show the image
    }
}
