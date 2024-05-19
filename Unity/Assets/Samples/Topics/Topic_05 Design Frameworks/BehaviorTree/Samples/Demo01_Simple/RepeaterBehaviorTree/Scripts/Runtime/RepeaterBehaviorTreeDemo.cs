using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
	public class RepeaterBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]
		private RepeaterBehaviorTree _behaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_behaviorTree = new RepeaterBehaviorTree();
			_behaviorTree.Initialize();

		}

		private void Update()
		{
			_behaviorTree.OnTick(Time.deltaTime);
		}
	}
}