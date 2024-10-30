// GameManager01.cs
using UnityEngine;
	
public class GameManager01 : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        // Player player = FindObjectOfType<Player>();
        if (player != null)
        {
            // Subscribe to the PowerUpCollected event
            //player.PowerUpCollected += HandlePowerUpCollected;
        }
    }

    // Method to handle the PowerUpCollected event
    void HandlePowerUpCollected()
    {
        Debug.Log("Player collected a power-up!");
        // Perform relevant actions
    }
}