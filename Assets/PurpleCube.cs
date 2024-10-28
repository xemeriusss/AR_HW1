using UnityEngine;

public class PurpleCube : MonoBehaviour
{
    void Start()
    {
        // Get the Renderer component from the cube GameObject
        Renderer cubeRenderer = GetComponent<Renderer>();

        // Create a new Color with purple values (R, G, B)
        Color purpleColor = new Color(0.5f, 0.0f, 0.5f);

        // Apply the color to the cube's material
        cubeRenderer.material.color = purpleColor;
    }
}
