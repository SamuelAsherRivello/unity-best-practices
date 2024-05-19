namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.MementoPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class Caretaker
	{
		private PlayerOriginator _originator;
		private Memento _memento;

		public Caretaker (PlayerOriginator originator)
		{
			_originator = originator;
		}

		public void Save()
		{
			if (_originator == null)
			{
				return;
			}
			_memento = _originator.CreateMemento();
		}

		public void Restore()
		{
			if (_memento == null)
			{
				return;
			}
			_originator.RestoreMemento(_memento);
		}
	}
}