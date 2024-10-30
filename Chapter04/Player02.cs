// Player01.cs (version 2)
using UnityEngine;
	
public class Playe02 : MonoBehaviour
{
    // Define a delegate type for the PowerUpCollected event
    public delegate void PowerUpCollectedEventHandler();

    // Define the event using the delegate type
    public event PowerUpCollectedEventHandler PowerUpCollected;

    void OnTriggerEnter(Collider other)
    { 
        if (other.CompareTag("PowerUp"))
        { 
            // Trigger the PowerUpCollected event
            OnPowerUpCollected(); 
            Destroy(other.gameObject); // Destroy the power-up object
        }
    }

    // Method to trigger the PowerUpCollected event
    protected virtual void OnPowerUpCollected()
    {
        PowerUpCollected?.Invoke();
    }
}