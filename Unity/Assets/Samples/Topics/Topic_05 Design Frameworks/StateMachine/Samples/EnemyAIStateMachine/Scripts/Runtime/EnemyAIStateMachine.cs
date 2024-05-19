using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.Frameworks.StateMachineFramework.Sample
{
	public class EnemyAIStateMachine : BaseDemo
	{
		//[Header("Demo")]
		
		protected override void Start()
		{
			// Must call base
			base.Start();
			
			Debug.Log("EnemyAIStateMachine");
		}

		private void Update()
		{
		}
	}
}