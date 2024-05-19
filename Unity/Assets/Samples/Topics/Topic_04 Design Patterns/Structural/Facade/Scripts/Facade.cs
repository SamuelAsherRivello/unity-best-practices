using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// Wrap 1 or more subsystems
	/// </summary>
	public class Facade
	{
		private GameObject _player;
		private AudioSystem _audioSystem;
		private MovementSystem _movementSystem;

		public Facade (GameObject player, AudioSystem audioSystem)
		{
			_player = player;
			_audioSystem = audioSystem;
			_movementSystem = new MovementSystem();
		}

		public void UpAction()
		{
			_audioSystem.PlayAudioClip(0);
			_movementSystem.MoveUp(_player);
		}

		public void DownAction()
		{
			_audioSystem.PlayAudioClip(0);
			_movementSystem.MoveDown(_player);
		}

		public void LeftAction()
		{
			_audioSystem.PlayAudioClip(0);
			_movementSystem.MoveLeft(_player);
		}

		public void RightAction()
		{
			_audioSystem.PlayAudioClip(0);
			_movementSystem.MoveRight(_player);
		}
	}
}