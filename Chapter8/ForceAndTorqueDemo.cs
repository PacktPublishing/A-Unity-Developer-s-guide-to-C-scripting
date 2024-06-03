// ForceAndTorqueDemo.cs
using UnityEngine;

public class ForceAndTorqueDemo : MonoBehaviour
{
    public float forceMagnitude = 10f;
    public float torqueMagnitude = 5f;

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check for user input to apply force
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply an upward force to the Rigidbody
            rb.AddForce(Vector3.up * forceMagnitude,
                ForceMode.Impulse);
        }

        // Check for user input to apply torque
        if (Input.GetKeyDown(KeyCode.T))
        {
            // Apply a rotational force (torque) around the Z-axis
            rb.AddTorque(Vector3.forward * torqueMagnitude, 
                ForceMode.Impulse);
        }
    }
}