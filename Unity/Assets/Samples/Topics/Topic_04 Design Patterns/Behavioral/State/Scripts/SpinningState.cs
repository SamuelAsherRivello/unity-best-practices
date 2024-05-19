using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.StatePattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class SpinningState : State
	{
		public SpinningState(StateReceiver stateReceiver) : base(stateReceiver) { }

		public override void Update(float deltaTime)
		{
			_stateReceiver.transform.Rotate(new Vector3(0, -deltaTime * 100, 0));
		}
	}
}