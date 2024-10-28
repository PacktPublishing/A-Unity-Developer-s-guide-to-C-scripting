// CombatController.cs
using UnityEngine; // Inserted for completeness
public class CombatController : MonoBehaviour
{
    private int comboSequence = 0;

    public void Attack()
    {
        comboSequence++;
        if (comboSequence == 3)
        {
            // Perform special attack
            comboSequence = 0;
        }
    }
}

// Note: In the book, this is a code snippet. It lacks the "Using UnityEngine" statement.