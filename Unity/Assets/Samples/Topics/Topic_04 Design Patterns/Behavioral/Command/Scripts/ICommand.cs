using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.CommandPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public interface ICommand
	{
		void Execute();
		void Undo();
	}
}