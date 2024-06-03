// RotateSymbol.cs
using UnityEngine; // Inserted for completeness
public class RotateSymbol : MonoBehaviour
{
    public void Rotate(float angle)
    {
        transform.Rotate(0, 0, angle);
    }
}

// Note: In the book, this is a code snippet. It lacks the "Using UnityEngine" statement.