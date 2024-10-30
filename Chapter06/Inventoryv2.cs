// Inventory01.cs (version 2)
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public bool RemoveItem(string item)
    {
        return items.Remove(item);
    }

    public bool CheckItem(string item)
    {
        return items.Contains(item);
    }
}
