using System.Collections.Generic;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.StatePattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class Context
	{
		public IState CurrentState
		{
			get
			{
				return _currentState;
			}
			set
			{
				if (_currentState == value)
				{
					return;
				}

				if (_currentState != null)
				{
					_currentState.ExitState();
				}

				_currentState = value;

				if (_currentState != null)
				{
					_currentState.EnterState();
				}
			}
		}

		public List<IState> _stateList;

		private IState _currentState;

		public Context()
		{
			_stateList = new List<IState>();
		}

		public void AddState (IState state)
		{
			_stateList.Add(state);
		}

		public void Update (float deltaTime)
		{
			if (_currentState == null)
			{
				return;
			}

			_currentState.Update(deltaTime);
		}

		public void Hover()
		{
			CurrentState = _stateList[0];
		}

		public void Spin()
		{
			CurrentState = _stateList[1];
		}
	}
}