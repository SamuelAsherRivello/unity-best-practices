using RMC.BestPractices.Shared;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.StandardBuilder
{
	public class Spawner : ISpawner
	{
		private GameObject _prefab;
		private Vector3 _position;
		private Quaternion _rotation;
		
		public Spawner(GameObject prefab, Vector3 position, Quaternion rotation)
		{
			_prefab = prefab;
			_position = position;
			_rotation = rotation;
		}
		public void Spawn()
		{
			GameObject go = GameObject.Instantiate(_prefab, _position, _rotation);
			
			//Assumption
			Bullet bullet = go.GetComponent<Bullet>();
		}
	}
}
