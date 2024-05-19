
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.FluentBuilder
{
	
	public class SpawnerFluentBuilder : ISpawnerFluentBuilder
	{
		private GameObject _prefab;
		private Vector3 _position;
		private Quaternion _rotation;

		public ISpawnerFluentBuilder SetPrefab(GameObject prefab)
		{
			_prefab = prefab;
			return this;
		}

		public ISpawnerFluentBuilder SetPosition(Vector3 position)
		{
			_position = position;
			return this;
		}

		public ISpawnerFluentBuilder SetRotation(Quaternion rotation)
		{
			_rotation = rotation;
			return this;
		}

		public ISpawner Build()
		{
			return new Spawner(_prefab, _position, _rotation);
		}
	}
}