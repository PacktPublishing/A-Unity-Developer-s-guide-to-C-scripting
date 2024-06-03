// Collectibles.cs
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Logic for collecting the item
            Destroy(gameObject);
        }
    }
}