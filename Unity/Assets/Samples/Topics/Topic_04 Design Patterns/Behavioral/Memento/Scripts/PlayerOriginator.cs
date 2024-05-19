
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.BehavioralPatterns.MementoPattern
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class PlayerOriginator : Originator
	{
		public void Randomize ()
		{
			Vector3 position = new Vector3();
			position.x = Random.Range(0, 3f);
			position.y = Random.Range(0, 3f);
			position.z = Random.Range(0, 3f);

			Vector3 localScale = new Vector3();
			localScale.x = Random.Range(.1f, 3f);
			localScale.y = localScale.x;
			localScale.z = localScale.x;

			Vector3 rotation = new Vector3();
			rotation.x = Random.Range(0, 180);
			rotation.y = Random.Range(0, 180);
			rotation.z = Random.Range(0, 180);

			transform.position = position;
			transform.localScale = localScale;
			transform.rotation = Quaternion.Euler(rotation);
		}

		public override Memento CreateMemento()
		{
			return new PlayerMemento(transform.position, transform.localScale, transform.rotation);
		}

		public override void RestoreMemento(Memento memento)
		{
			PlayerMemento playerMemento = memento as PlayerMemento;
			transform.position = playerMemento.Position;
			transform.localScale = playerMemento.LocalScale;
			transform.rotation = playerMemento.Rotation;
		}
	}
}