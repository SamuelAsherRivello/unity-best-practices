
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.OrderedBuilder
{
	
	
	/// <summary>
	/// 1. Must instantiate this one first
	/// </summary>
	public class SpawnerOrderedBuilder : ISpawnerOrderedBuilderFirst
	{
		private GameObject _prefab;
		private Vector3 _position;
		private Quaternion _rotation;

		/// <summary>
		/// 2. Must call this one second
		/// </summary>
		public ISpawnerOrderedBuilderSecond SetPrefab(GameObject prefab)
		{
			_prefab = prefab;
			return this;
		}

		/// <summary>
		/// 3. Must call this one third
		/// </summary>
		public ISpawnerOrderedBuilderThird SetPosition(Vector3 position)
		{
			_position = position;
			return this;
		}

		/// <summary>
		/// 4. Must call this one Fourth
		/// </summary>
		public ISpawnerOrderedBuilderFourth SetRotation(Quaternion rotation)
		{
			_rotation = rotation;
			return this;
		}

		/// <summary>
		/// 5. Must call this one last
		/// </summary>
		public ISpawner Build()
		{
			return new Spawner(_prefab, _position, _rotation);
		}
	}
}