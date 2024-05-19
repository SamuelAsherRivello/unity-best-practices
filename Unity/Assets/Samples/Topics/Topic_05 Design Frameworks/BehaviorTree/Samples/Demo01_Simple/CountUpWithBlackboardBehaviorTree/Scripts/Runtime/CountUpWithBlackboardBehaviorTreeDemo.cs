using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
	public class CountUpWithBlackboardBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]

		private CountUpWithBlackboardBehaviorTree _behaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_behaviorTree = new CountUpWithBlackboardBehaviorTree();
			_behaviorTree.Initialize();

		}

		private void Update()
		{
			_behaviorTree.OnTick(Time.deltaTime);
		}
	}
}