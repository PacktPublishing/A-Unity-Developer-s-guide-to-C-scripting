// InventoryManager01.cs
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Dictionary to hold item IDs and their names
    Dictionary<int, string> inventory = new Dictionary<int, string>();

    void Start()
    {
        // Adding items to the dictionary
        inventory.Add(1, "Sword");
        inventory.Add(2, "Shield");
        inventory.Add(3, "Health Potion");

        // Displaying an item name by its ID
        Debug.Log("Item with ID 1: " + inventory[1]);
    }
}