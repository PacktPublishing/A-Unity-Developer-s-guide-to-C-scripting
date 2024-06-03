// MotionControl.cs
using UnityEngine;

public class MotionControl : MonoBehaviour
{
    public float sensitivity = 1.0f;

    void Update()
    {
        Vector3 tilt = Input.acceleration * sensitivity;
        // Use tilt.x and tilt.y to control game objects
        transform.Translate(tilt.x, 0, tilt.y);
    }
}
