// ArrayExample.cs
using UnityEngine;
	
public class ArrayExample : MonoBehaviour
{
    // Array of positions for game objects
    public Vector3[] positions = new Vector3[5];

    void Start()
    {
        // Initialize positions
        for (int i = 0; i < positions.Length; i++)
        {
            positions[i] = new Vector3(i * 2.0f, 0, 0);
        }
    }

    void Update()
    {
        // Iterate over positions and update each
        for (int i = 0; i < positions.Length; i++)
        {
            // Example update: move each position upwards every frame
            positions[i] += Vector3.up * Time.deltaTime;
        }
    }
}
