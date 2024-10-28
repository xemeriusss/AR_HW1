using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimationController : MonoBehaviour
{
    // Reference to the Animator component
    private Animator cubeAnimator;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component from the cube
        cubeAnimator = GetComponent<Animator>();

        // Change the cube's color to purple
        Renderer cubeRenderer = GetComponent<Renderer>();
        if (cubeRenderer != null)
        {
            // Set the material color to purple (R: 128, G: 0, B: 128)
            cubeRenderer.material.color = new Color(0.5f, 0.0f, 0.5f);
        }
        else
        {
            Debug.LogError("Renderer not found!");
        }

        // Play the animation
        if (cubeAnimator != null)
        {
            cubeAnimator.Play("my_animation");
        }
        else
        {
            Debug.LogError("Animator not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Optional: You can trigger the animation on some condition, like a tap or gesture
        // if (SomeCondition)
        // {
        //     cubeAnimator.SetTrigger("YourTrigger");
        // }
    }
}
