using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Start playing the video when the game starts
        videoPlayer.Play();
    }

    void Update()
    {
        // Optional: Restart the video if it ends
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }

    // Optional: Method to stop the video
    public void StopVideo()
    {
        videoPlayer.Stop();
    }
}
