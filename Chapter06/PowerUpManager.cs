// PowerUpManager.cs
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    HashSet<string> collectedPowerUps = new HashSet<string>();

    void CollectPowerUp(string powerUpName)
    {
        // Adds the power-up to the collection if it's not already present
        bool added = collectedPowerUps.Add(powerUpName);
        if (added)
        {
            Debug.Log(powerUpName + " collected!");
        }
    }
}