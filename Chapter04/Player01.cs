// Player01.cs
using UnityEngine;

public class Player01 : MonoBehaviour
{
    public Health health; // Reference to the Health script 

    void Start()
    { 
        // Accessing methods from the Health script
        health.TakeDamage(10);
    }
}