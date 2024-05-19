using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.StatePattern
{
	/// <summary>
	/// Allow an object to alter its behavior when its internal state changes. 
	/// The object will appear to change its class.
	/// See <a href="https://www.dofactory.com/net/state-design-pattern">docs</a>.
	/// </summary>
	public class StatePattern : BaseDemo
	{
		[Header("Demo")]
		
		[SerializeField]
		private StateReceiver _stateReceiver = null;

		private Context _context;

		protected override void Start()
		{
			// Must call base
			base.Start();

			_context = new Context();
			_context.AddState(new HoveringState(_stateReceiver));
			_context.AddState(new SpinningState(_stateReceiver));

			_context.Hover();
		}

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				Debug.Log("Hover");
				_context.Hover();
			}

			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				Debug.Log("Spin");
				_context.Spin();
			}

			_context.Update(Time.deltaTime);
		}
	}
}