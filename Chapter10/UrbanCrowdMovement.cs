// UrbanCrowdMovement.cs
using UnityEngine;
using UnityEngine.AI;

public class UrbanCrowdMovement : MonoBehaviour
{
    public Transform[] waypoints;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(waypoints[Random.Range(0, 
            waypoints.Length)].position);
    }

    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            agent.SetDestination(waypoints[Random.Range(0, 
                waypoints.Length)].position);
        }
    }
}