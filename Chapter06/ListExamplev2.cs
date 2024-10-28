// ListExample.cs (version #2)
using System.Collections.Generic;
using UnityEngine;

public class ListExample : MonoBehaviour
{
    List<int> scores = new List<int>();

    void Start()
    {
        // Adding elements
        scores.Add(10);
        scores.Add(20);

        // Accessing elements
        Debug.Log("First score: " + scores[0]);

        // Iterating over the list
        foreach (int score in scores)
        {
            Debug.Log("Score: " + score);
        }

        // Removing elements
        scores.Remove(10);
    }
}
