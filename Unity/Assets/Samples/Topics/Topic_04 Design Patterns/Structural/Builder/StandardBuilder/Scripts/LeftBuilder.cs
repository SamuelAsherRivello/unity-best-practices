
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.StandardBuilder
{
	
	public class LeftBuilder : AbstractBuilder
	{
		private GameObject _prefab;
		private Vector3 _position;
		private Quaternion _rotation;

		public override void SetPrefab(GameObject prefab)
		{
			_prefab = prefab;
		}

		public override void SetPosition(Vector3 position)
		{
			_position = position + Vector3.left;
		}

		public override void SetRotation(Quaternion rotation)
		{
			_rotation = rotation;
		}

		public override ISpawner Build()
		{
			return new Spawner(_prefab, _position, _rotation);
		}
	}
}