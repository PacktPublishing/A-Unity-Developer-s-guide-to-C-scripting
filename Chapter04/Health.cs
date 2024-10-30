// Health.cs
using UnityEngine;

public class Health : MonoBehaviour
{
    public int healthPoints; 

    // Getter method to retrieve healthPoints
    public int GetHealth()
    { 
        return healthPoints;	
    }


    // Setter method to update healthPoints
    public int SetHealth(int value)
    { 
        healthPoints = value;	
        return healthPoints;
    }


    // Method to apply damage to health
    public void TakeDamage(int damageAmount)
    { 
        healthPoints -= damageAmount;	
        Debug.Log("Player took " + damageAmount + 
                  " damage. Current health: " + healthPoints);
    }
}