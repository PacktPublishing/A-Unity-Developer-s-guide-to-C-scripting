// Mover.cs

using UnityEngine;

Public class Mover: MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        // Move the game object forward continuously at the 
        // speed specified
        transform.Translate(Vector3.forward * speed *
                            Time.deltaTime);
    }
}