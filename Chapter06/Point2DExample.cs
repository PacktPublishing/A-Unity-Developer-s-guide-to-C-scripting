// Point2DExample.cs
using UnityEngine;

public class Point2DExample : MonoBehaviour
{
    void Start()
    {
        // Create an instance of Point2D
        Point2D point = new Point2D(3, 4);

        // Log the initial coordinates
        Debug.Log("Initial Point: (" + point.X + ", " + 
                  point.Y + ")");

        // Translate the point
        point.Translate(2, 3);

        // Log the new coordinates after translation
        Debug.Log("Translated Point: (" + point.X + ", " + 
                  point.Y + ")");
    }
}

public struct Point2D
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Translate(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }
}