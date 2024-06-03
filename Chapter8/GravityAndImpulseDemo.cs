// GravityAndImpulseDemo.cs
using UnityEngine;

public class GravityAndImpulseDemo : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the GameObject
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check for user input to apply an impulse force
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Apply an impulse force upwards to simulate a jump
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}