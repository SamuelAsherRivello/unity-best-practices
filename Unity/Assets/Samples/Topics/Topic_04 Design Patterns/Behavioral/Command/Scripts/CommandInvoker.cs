using System.Collections.Generic;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.CommandPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class CommandInvoker
	{
		public List<ICommand> _commandList;

		public CommandInvoker()
		{
			_commandList = new List<ICommand>();
		}

		public void AddCommand (ICommand command)
		{
			_commandList.Add(command);
		}

		public void Execute()
		{
			_commandList[_commandList.Count -1].Execute();
		}

		public void Undo()
		{
			if (_commandList.Count == 0)
			{
				return;
			}
			_commandList[_commandList.Count - 1].Undo();
			_commandList.RemoveAt(_commandList.Count - 1);
		}
	}
}