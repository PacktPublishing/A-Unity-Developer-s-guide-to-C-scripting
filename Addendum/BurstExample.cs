using Unity.Burst;
using Unity.Jobs;
using UnityEngine;

// Needs Unity's Job and Burst system installed
/* public class BurstExample : MonoBehaviour
{
	[BurstCompile]
	struct ComplexCalculationJob : IJob
	{
		public void Execute()
		{
		// Perform complex calculations here
	}
	}
	void Start()
	{
		ComplexCalculationJob job = new ComplexCalculationJob();
		JobHandle jobHandle = job.Schedule();
		jobHandle.Complete(); // Ensures the job completes before proceeding
	}
} */