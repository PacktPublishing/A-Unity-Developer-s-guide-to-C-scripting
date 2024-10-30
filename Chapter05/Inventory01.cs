// Inventory01.cs
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Inventory01 : MonoBehaviour
{
    public List<Progress.Item> items = new List<Progress.Item>();

    public void AddItem(Progress.Item item)
    {
        items.Add(item);
    }
}