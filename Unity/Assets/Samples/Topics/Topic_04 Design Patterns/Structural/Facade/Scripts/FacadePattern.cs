using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// Attach additional responsibilities to an object dynamically. 
	/// Decorators provide a flexible alternative to subclassing for extending functionality.
	/// See <a href="https://www.dofactory.com/net/decorator-design-pattern">docs</a>.
	/// </summary>
	public class FacadePattern : BaseDemo
	{
		[Header("Demo")]
		[SerializeField]
		private GameObject _gameObject = null;

		[SerializeField]
		private AudioSystem _audioSystem = null;

		private Facade _facade;

		protected override void Start()
		{
			// Must call base
			base.Start();

			_facade = new Facade(_gameObject, _audioSystem);
		}

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				_facade.UpAction();
			}

			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				_facade.DownAction();
			}

			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				_facade.LeftAction();
			}

			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				_facade.RightAction();
			}
		}
	}
}