using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Flyweight
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class FlyweightFactory 
	{
		private GameObject _prefab;

		public FlyweightFactory (GameObject prefab)
		{
			_prefab = prefab;
		}

		public Orbiter CreateOrbiter ()
		{
			Orbiter orbiter = GameObject.Instantiate(_prefab).GetComponent<Orbiter>();

			Vector3 scale = new Vector3();
			scale.x = Random.Range(.2f, 1f);
			scale.y = scale.x;
			scale.z = scale.x;
			orbiter.transform.localScale = scale;

			return orbiter;
		}
	}
}