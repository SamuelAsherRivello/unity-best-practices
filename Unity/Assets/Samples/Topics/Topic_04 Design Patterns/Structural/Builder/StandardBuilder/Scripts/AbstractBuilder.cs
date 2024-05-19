
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.StandardBuilder
{
	
	public abstract class AbstractBuilder
	{
		public abstract void SetPrefab(GameObject prefab);
		public abstract void SetPosition(Vector3 position);
		public abstract void SetRotation(Quaternion rotation);
		public abstract ISpawner Build();
	}
}