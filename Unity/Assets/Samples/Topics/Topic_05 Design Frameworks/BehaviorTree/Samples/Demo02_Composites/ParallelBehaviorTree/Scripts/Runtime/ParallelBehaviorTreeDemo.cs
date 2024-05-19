using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
	public class ParallelBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]

		private ParallelBehaviorTree _behaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_behaviorTree = new ParallelBehaviorTree();
			_behaviorTree.Initialize();

		}

		private void Update()
		{
			_behaviorTree.OnTick(Time.deltaTime);
		}
	}
}