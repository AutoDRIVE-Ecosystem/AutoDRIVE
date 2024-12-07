/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManagerAgentRBM : MonoBehaviour
{
    // This stores the current angle of rotation around the X-axis
    public float currentAngle;

    // Public variable to specify the target angle for rotation
    public float targetAngle;

    // The speed at which the sun rotates towards the target angle (in degrees per second)
    public float rotationSpeed = 50f;

    void Start()
    {
        // Cache the initial target angle based on the current local X rotation of the GameObject
        targetAngle = transform.localEulerAngles.x;

        // Optionally, you can initialize the current angle as well
        currentAngle = targetAngle;
    }

    void Update()
    {
        // Lerp the rotation from the current angle to the target angle on the X-axis
        float newAngle = Mathf.LerpAngle(currentAngle, targetAngle, Time.deltaTime * rotationSpeed);

        // Apply the rotation to the sun along its local X-axis
        transform.localRotation = Quaternion.Euler(newAngle, 0f, 0f);

        // Update the current angle for the next frame
        currentAngle = newAngle;

        // Optionally, check if we are very close to the target angle and stop lerping (to avoid overshooting)
        if (Mathf.Abs(currentAngle - targetAngle) < 0.1f)
        {
            currentAngle = targetAngle; // Snap to target angle to avoid minor floating-point issues
        }
    }
}*/