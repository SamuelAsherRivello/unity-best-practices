using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.MementoPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public abstract class Originator : MonoBehaviour
	{
		public abstract Memento CreateMemento();
		public abstract void RestoreMemento(Memento memento);
	}
}