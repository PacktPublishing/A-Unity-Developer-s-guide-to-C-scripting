// EnemyController.cs
using UnityEngine; 
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    void Update()
    {
        // Follow the player
        agent.SetDestination(player.position);
    }
}