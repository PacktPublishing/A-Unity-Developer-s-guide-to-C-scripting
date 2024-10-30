// Inventory01.cs

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class Inventory02 : ScriptableObject
{
    public List<Progress.Item> items = new List<Progress.Item>();
    
    public void AddItem(Progress.Item itemToAdd)
    {
        // Add item logic here
    }
}