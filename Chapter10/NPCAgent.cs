// NPCAgent.cs

// Needs Unity.MLAgents package installed

/*using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class NPCAgent : Agent
{
    public override void OnEpisodeBegin()
    {
        // Reset the NPC state for new episode
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        // Add NPC's observations of the environment
        for decision making
    }

    public override void OnActionReceived(ActionBuffers actionBuffers)
    {
        // Actions received from the model
        int action = actionBuffers.DiscreteActions[0];
        if (action == 1)
        {
            // Perform the action, e.g., move towards a target
        }
    }

    public override void Heuristic(in ActionBuffers actionsOut)
    {
        // Provide manual control as fallback
        actionsOut.DiscreteActions.Array[0] = 
            Convert.ToInt32(Input.GetKey(KeyCode.Space));
    }
}  */