// ApplyForce.cs
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 forceDirection;
    public float forceMagnitude;

    void Start()
    {
        rb.AddForce(forceDirection.normalized * 
                    forceMagnitude);
    }
}