// NarrativeController.cs
using UnityEngine; // Inserted for completeness
public class NarrativeController : MonoBehaviour
{
    public void MakeChoice(int choice)
    {
        switch (choice)
        {
            case 1:
                // Trigger one storyline
                break;
            case 2:
                // Trigger an alternative storyline
                break;
        }
    }
}

// Note: In the book, this is a code snippet. It lacks the "Using UnityEngine" statement.