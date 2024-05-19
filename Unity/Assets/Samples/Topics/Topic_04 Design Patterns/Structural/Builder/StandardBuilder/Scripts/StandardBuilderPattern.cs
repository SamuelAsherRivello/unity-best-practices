using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.StandardBuilder
{
	/// <summary>
	/// The Builder design pattern separates the construction of a complex object
	/// from its representation so that the same construction process can create
	/// different representations.
	/// 
	/// See <a href="https://www.dofactory.com/net/builder-design-pattern">docs</a>.
	///
	///
	/// TODO: I'm not sure this "standard" builder follows the typical setup.
	/// Continue to R&D on it.
	/// 
	/// </summary>
	public class StandardBuilderPattern : BaseDemo
	{
		[Header("Demo")]
		[SerializeField]
		private GameObject _prefab = null;

		[SerializeField]
		private Transform _transform;

		private ISpawner _leftSpawner;
		private ISpawner _rightSpawner;


		protected override void Start()
		{
			// Must call base
			base.Start();

			// Create Director
			Director director = new Director();
			
			////////////////////////////////////////////
			// UP
			// Create Builder
			AbstractBuilder leftBuilder = new LeftBuilder();
			director.Construct(leftBuilder, _prefab, transform.position, Quaternion.identity);
			
			// Create the spawner
			_leftSpawner = leftBuilder.Build();
			
			////////////////////////////////////////////
			// Right
			// Create Builder
			AbstractBuilder rightBuilder = new RightBuilder();
			director.Construct(rightBuilder, _prefab, transform.position, Quaternion.identity);
			
			// Create the spawner
			_rightSpawner = rightBuilder.Build();
	
		}

		protected void Update()
		{
			if (Input.GetKeyDown(KeyCode.LeftShift))
			{
				_leftSpawner.Spawn();
			}
			
			if (Input.GetKeyDown(KeyCode.RightShift))
			{
				_rightSpawner.Spawn();
			}
		}
	}
}