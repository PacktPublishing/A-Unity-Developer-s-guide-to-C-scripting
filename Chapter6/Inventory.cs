// Inventory.cs
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class Inventory : ScriptableObject
{
    public List<Item> items = new List<Item>();
    
    public void AddItem(Item itemToAdd)
    {
        // Add item logic here
    }
}