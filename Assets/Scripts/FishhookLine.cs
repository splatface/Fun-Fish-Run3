using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class FishhookLine : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private Camera mainCam;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        mainCam = Camera.main;
    }

    void Update()
    {
        if (lineRenderer == null || mainCam == null)
            return;

        // End point = fishhook position
        Vector3 endPos = transform.position;
         endPos.y += 0.3f;
        // Start point = same x as fishhook, but top of screen
        Vector3 topOfScreen = mainCam.ViewportToWorldPoint(
            new Vector3(0.5f, 1f, Mathf.Abs(mainCam.transform.position.z))
        );

        // Align with fishhook x-position
        topOfScreen.x = transform.position.x;
        topOfScreen.z = 0f; // make sure it’s 2D

        // Update line positions
        lineRenderer.SetPosition(0, topOfScreen);
        lineRenderer.SetPosition(1, endPos);
    }
}
