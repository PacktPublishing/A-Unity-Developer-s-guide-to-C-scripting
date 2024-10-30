// PatrolGuardAI.cs

using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine; // Inserted for completeness
public class PatrolGuardAI : MonoBehaviour
{
    // This is indeed for visual display in Unity's Behavior Tree window.
    
    /*private BehaviorTree tree;

    void Start()
    {
        tree = new BehaviorTree();

        Node root = new SelectorNode();
        Node patrolNode = new SequenceNode(new List<Node>
        {
            new CheckPatrolAreaNode(),
            new MoveToNode(patrolPath),
        });
        Node chaseNode = new SequenceNode(new List<Node>
        {
            new CanSeePlayerNode(),
            new ChasePlayerNode(),
        });
        Node investigateNode = new SequenceNode(new List<Node>
        {
            new HeardNoiseNode(),
            new InvestigateNoiseNode(),
        });

        root.AddChild(patrolNode);
        root.AddChild(chaseNode);
        root.AddChild(investigateNode);

        tree.SetRoot(root);
    }

    void Update()
    {
        tree.Tick(); // Process the behavior tree
    }*/
        
}