using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.OrderedBuilder
{
	/// <summary>
	/// The Builder design pattern separates the construction of a complex object
	/// from its representation so that the same construction process can create
	/// different representations.
	/// 
	/// See <a href="https://www.dofactory.com/net/builder-design-pattern">docs</a>.
	/// </summary>
	public class OrderedBuilderPattern : BaseDemo
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
			ISpawnerOrderedBuilderFirst builderFirst = new SpawnerOrderedBuilder();
			
			//Required: Must call in this specific order
			//1
			_spawner =  builderFirst.
				
				//2
				SetPrefab(_prefab.gameObject).
				
				//3
				SetPosition(_transform.position + Vector3.up).
				
				//4
				SetRotation(Quaternion.identity).
				
				//5
				Build();
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