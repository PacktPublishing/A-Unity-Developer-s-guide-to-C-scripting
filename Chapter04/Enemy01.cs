// Enemy01.cs
using UnityEngine;
	
public class Enemy01 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    { 
        if (collision.gameObject.CompareTag("Player"))	
        {
            // Send message to the collided player 
            // object to take damage
            collision.gameObject.SendMessage("TakeDamage", 10);
        }
    }
}