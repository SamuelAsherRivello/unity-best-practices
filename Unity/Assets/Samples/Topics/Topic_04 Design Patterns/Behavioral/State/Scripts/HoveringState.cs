using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.StatePattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class HoveringState : State
	{
		private float _counter = 0;
		private Vector3 _originalPosition;

		public HoveringState(StateReceiver stateReceiver) : base(stateReceiver)
		{
			_originalPosition = _stateReceiver.transform.position;
		}
		public override void Update(float deltaTime)
		{
			_counter += deltaTime;

			float y = Mathf.Sin(_counter) * 0.5f;
			_stateReceiver.transform.position = _originalPosition + new Vector3(0, y, 0);
		}
	}
}