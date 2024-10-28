using UnityEngine;

public class InteractionScenario : MonoBehaviour
{
    private Renderer cubeRenderer;

    void Start()
    {
        // Get the Renderer component of the cube
        cubeRenderer = GetComponent<Renderer>();
    }

    void OnMouseDown()
    {
        // When the cube is clicked, change its color to a random color
        ChangeColor();
    }

    void ChangeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        cubeRenderer.material.color = newColor;
    }
}
