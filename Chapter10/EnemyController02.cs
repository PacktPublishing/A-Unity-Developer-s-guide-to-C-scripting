// EnemyController02.cs
using UnityEngine; // Inserted for completeness
public class EnemyController02 : MonoBehaviour
{
    private Animator animator;
    private Transform player;
    private float detectionRange = 10.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        float distanceToPlayer = 
            Vector3.Distance(transform.position, 
                player.position);
        if (distanceToPlayer < detectionRange)
            animator.SetTrigger("Chase");
        else
            animator.SetTrigger("Patrol");
    }
}

// Note: In the book, this is a code snippet. It lacks the "Using UnityEngine" statement.