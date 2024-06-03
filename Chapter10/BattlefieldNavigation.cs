// BattlefieldNavigation.cs
using UnityEngine;
using UnityEngine.AI;

public class BattlefieldNavigation : MonoBehaviour
{
    public Transform[] coverPoints;
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void FindCover()
    {
        Transform bestCover = coverPoints[0];
        float closestDistance = 
            Vector3.Distance(transform.position, bestCover.position);

        foreach (Transform cover in coverPoints)
        {
            float distance = Vector3.Distance(transform.position, 
                cover.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                bestCover = cover;
            }
        }

        agent.destination = bestCover.position;
    }
}