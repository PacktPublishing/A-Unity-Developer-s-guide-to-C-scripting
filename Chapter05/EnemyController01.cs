// EnemyController02.cs
using UnityEngine; 
using UnityEngine.AI;

public class EnemyController01 : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    void Update()
    {
        // Follow the player
        agent.SetDestination(player.position);
    }
}