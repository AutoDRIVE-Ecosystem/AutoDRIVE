using UnityEngine;

public class Turntable : MonoBehaviour
{
    public float rotationSpeed = 50f;  // Speed of rotation in degrees per second

    void Update()
    {
        // Rotate the object around the Y-axis (you can adjust axes or angles as needed)
        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.World);
    }
}