// using Unity.Jobs;
// using UnityEngine;

// Needs Unity Job and Burst system installed
/* public class JobExample : MonoBehaviour
{
	private struct SimpleJob : IJob
	{
		public void Execute()
		{
			// Perform heavy computation here
			Debug.Log("Job executed!");
		}
	}
	void Start()
	{
		// Schedule the job to run on a worker thread
	SimpleJob job = new SimpleJob();
	JobHandle jobHandle = job.Schedule();
	jobHandle.Complete(); // Ensure the job is finished before
	proceeding
	}
} /*