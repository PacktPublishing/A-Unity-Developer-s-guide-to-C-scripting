// UtilityDecider.cs
using UnityEngine; // Inserted for completeness
public class UtilityDecider : MonoBehaviour
{
    public float attackUtility;
    public float defendUtility;
    public float specialAbilityUtility;

    void DecideAction()
    {
        float maxUtility = Mathf.Max(attackUtility, 
            defendUtility, 
            specialAbilityUtility);
        if (maxUtility == attackUtility)
            PerformAttack();
        else if (maxUtility == defendUtility)
            PerformDefend();
        else
            PerformSpecialAbility();
    }

    void PerformAttack() { /* Implementation here */ }
    void PerformDefend() { /* Implementation here */ }
    void PerformSpecialAbility() { /* Implementation here */ }
}

// Note: In the book, this is a code snippet. It lacks the "Using UnityEngine" statement.