// InventoryManager.cs (Version 2)
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    Dictionary<string, int> inventory = new Dictionary<string, int>();

    void Start()
    {
        // Adding items to the inventory
        inventory.Add("Potion", 5);
        inventory.Add("Sword", 1);
    }

    void Update()
    {
        // Accessing and updating an item's quantity
        if (Input.GetKeyDown(KeyCode.U))
        {
            inventory["Potion"] += 1;
            Debug.Log("Potions: " + inventory["Potion"]);
        }
    }
}
