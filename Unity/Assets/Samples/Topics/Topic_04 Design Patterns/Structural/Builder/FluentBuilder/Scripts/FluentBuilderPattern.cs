using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.FluentBuilder
{
	/// <summary>
	/// The Builder design pattern separates the construction of a complex object
	/// from its representation so that the same construction process can create
	/// different representations.
	/// 
	/// See <a href="https://www.dofactory.com/net/builder-design-pattern">docs</a>.
	/// </summary>
	public class FluentBuilderPattern : BaseDemo
	{
		[Header("Demo")]
		[SerializeField]
		private GameObject _prefab = null;

		[SerializeField]
		private Transform _transform;

		private ISpawner _spawner;
		
		protected override void Start()
		{
			// Must call base
			base.Start();

			// Create Builder
			ISpawnerFluentBuilder builder = new SpawnerFluentBuilder();
			
			//Optional: Call any/all in any order
			builder.
				SetPrefab(_prefab.gameObject).
				SetPosition(_transform.position + Vector3.up).
				SetRotation(Quaternion.identity);
			
			// Required
			_spawner = builder.Build();
		}

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
			{
				_spawner.Spawn();
			}
		}
	}
}