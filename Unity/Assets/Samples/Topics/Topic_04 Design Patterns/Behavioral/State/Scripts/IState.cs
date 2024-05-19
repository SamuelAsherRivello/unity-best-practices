using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.StatePattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public interface IState
	{
		void EnterState();
		void Update(float deltaTime);
		void ExitState();
	}
}