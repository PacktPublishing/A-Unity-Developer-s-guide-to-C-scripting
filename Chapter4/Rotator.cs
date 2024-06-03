// Rotator.cs

using UnityEngine;

Public class Rotator: MonoBehaviour
{
    public float rotationSpeed = 90.0f; 
    // Degrees per second

    void Update()
    {
        // Rotate the game object around its up axis at the 
        // speed specified
        transform.Rotate(Vector3.up, rotationSpeed *
                                     Time.deltaTime);
    }
}