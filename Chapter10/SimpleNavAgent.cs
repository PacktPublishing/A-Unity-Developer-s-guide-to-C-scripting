// SimpleNavAgent.cs
using UnityEngine;
using UnityEngine.AI;

public class SimpleNavAgent : MonoBehaviour
{
    public Transform target; // Drag your target in the Inspector
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if(target != null)
            agent.SetDestination(target.position);
    }
}
