// WildlifeBehavior.cs
using UnityEngine;
using UnityEngine.AI;

public class WildlifeBehavior : MonoBehaviour
{
    public Transform[] roamPoints;
    private NavMeshAgent agent;
    private int destPoint = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GotoNextPoint();
    }

    void GotoNextPoint()
    {
        if (roamPoints.Length == 0)
            return;

        agent.destination = roamPoints[destPoint].position;
        destPoint = (destPoint + 1) % roamPoints.Length;
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}