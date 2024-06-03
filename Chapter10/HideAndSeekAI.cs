// HideAndSeekAI.cs
using UnityEngine; // Inserted for completeness
public class HideAndSeekAI : MonoBehaviour
{
    public Transform player;
    private float decisionTime = 1.0f; // Time between decisions
    private float lastDecisionTime = 0f;

    void Update()
    {
        if (Time.time > lastDecisionTime + decisionTime)
        {
            MakeDecision();
            lastDecisionTime = Time.time;
        }
    }

    void MakeDecision()
    {
        if (Vector3.Distance(transform.position, player.position) 
            < 10f)
        {
            // Logic to hide because the player is too close
            Debug.Log("Hiding");
        }
        else
        {
            // Logic to seek the player
            Debug.Log("Seeking");
        }
    }
}

// Note: In the book, this is a code snippet. It lacks the "Using UnityEngine" statement.