using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.BehaviorTreeFramework.Sample
{
	public class CountUpBehaviorTreeDemo : BaseDemo
	{
		//[Header("Demo")]
		private CountUpBehaviorTree _behaviorTree;
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			_behaviorTree = new CountUpBehaviorTree();
			_behaviorTree.Initialize();

		}

		private void Update()
		{
			_behaviorTree.OnTick(Time.deltaTime);
		}
	}
}