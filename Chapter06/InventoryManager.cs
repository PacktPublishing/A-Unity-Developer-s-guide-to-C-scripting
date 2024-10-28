// InventoryManager.cs
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    List<string> inventory = new List<string>();

    public void AddItem(string item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(string item)
    {
        inventory.Remove(item);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            foreach (var item in inventory)
            {
                Debug.Log("Inventory Item: " + item);
            }
        }
    }
}