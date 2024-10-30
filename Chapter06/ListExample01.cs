// ListExample01.cs
using System.Collections.Generic;
using UnityEngine;
	
public class ListExample01 : MonoBehaviour
{
    public List<GameObject> gameObjects;

    void Start()
    {
        gameObjects = new List<GameObject>();
        // Populate the list with game objects
        for (int i = 0; i < 5; i++)
        {
            GameObject obj = new GameObject("Object" + i);
            gameObjects.Add(obj);
        }
    }

    void Update()
    {
        // Example: Remove a game object from the list 
        // when the 'R' key is pressed
        if (Input.GetKeyDown(KeyCode.R) && gameObjects.Count > 0)
        {
            GameObject objToRemove = gameObjects[0];
            gameObjects.Remove(objToRemove);
            Destroy(objToRemove);
        }
    }
}