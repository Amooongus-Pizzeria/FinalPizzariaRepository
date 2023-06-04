using UnityEngine;

public class SpriteCutter : MonoBehaviour
{
    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Update()
    {
        // Update the line points based on user input or any other logic
        UpdateLinePoints();
    }

    private void UpdateLinePoints()
    {
        // Clear the existing line points
        lineRenderer.positionCount = 0;

        // Add new line points based on your desired logic
        // Here, we're creating a straight line from point A to point B
        Vector3 pointA = new Vector3(-5f, 0f, 0f);
        Vector3 pointB = new Vector3(5f, 0f, 0f);

        // Set the new line points
        lineRenderer.positionCount = 2;
        lineRenderer.SetPosition(0, pointA);
        lineRenderer.SetPosition(1, pointB);
    }
}
