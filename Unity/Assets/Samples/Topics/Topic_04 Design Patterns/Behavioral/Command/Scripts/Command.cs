using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.CommandPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class Command : ICommand
	{
		public CommandReceiver _commandReceiver;

		public Command (CommandReceiver commandReceiver)
		{
			_commandReceiver = commandReceiver;
		}

		public virtual void Execute ()
		{

		}

		public virtual void Undo()
		{

		}
	}
}