using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
	public class SequenceBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]

		private SequenceBehaviorTree _behaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_behaviorTree = new SequenceBehaviorTree();
			_behaviorTree.Initialize();

		}

		private void Update()
		{
			_behaviorTree.OnTick(Time.deltaTime);
		}
	}
}