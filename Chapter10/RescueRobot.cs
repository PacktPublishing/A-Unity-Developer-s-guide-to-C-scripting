// RescueRobot.cs
using UnityEngine;
using UnityEngine.AI;

public class RescueRobot : MonoBehaviour
{
    public Transform target;

    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
    }

    void Update()
    {
        // Add additional logic for dynamic obstacles and other 
        rescue-specific behaviors
    }
}