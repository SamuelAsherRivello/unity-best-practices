using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.MementoPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class PlayerMemento : Memento
	{
		public Vector3 Position {  get { return _position; } }
		public Vector3 LocalScale { get { return _localScale; } }
		public Quaternion Rotation { get { return _rotation; } }

		private Vector3 _position;
		private Vector3 _localScale;
		private Quaternion _rotation;

		public PlayerMemento (Vector3 position, Vector3 localScale, Quaternion rotation)
		{
			_position = position;
			_localScale = localScale;
			_rotation = rotation;
		}
	}
}