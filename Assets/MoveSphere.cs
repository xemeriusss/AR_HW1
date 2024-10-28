using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    public float speed = 5f;
    private Camera arCamera;

    void Start()
    {
        // Get the AR camera
        arCamera = Camera.main;

        // Get the Renderer component from the cube GameObject
        Renderer cubeRenderer = GetComponent<Renderer>();

        // Create a new Color with blue values (R, G, B)
        Color blueColor = new Color(0.0f, 0.0f, 1.0f);

        // Apply the color to the cube's material
        cubeRenderer.material.color = blueColor;
    }

    void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Ray ray = arCamera.ScreenPointToRay(touch.position);
            RaycastHit hit;

            // Perform raycasting based on touch input
            if (Physics.Raycast(ray, out hit))
            {
                // Check if the hit object is this GameObject
                if (hit.transform == transform)
                {
                    // Move the object to the touch position on the detected plane
                    Vector3 touchPosition = hit.point;
                    touchPosition.y = transform.position.y; // Keep the same height
                    
                    // Move the object directly to the touch position
                    transform.position = Vector3.MoveTowards(transform.position, touchPosition, speed * Time.deltaTime);
                }
            }
        }
    }
}
