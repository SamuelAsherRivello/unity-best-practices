
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Builder.StandardBuilder
{
	public class Director 
	{
		public AbstractBuilder Construct(AbstractBuilder builder, 
			GameObject prefab, Vector3 position, Quaternion rotation)
		{
			builder.SetPrefab(prefab.gameObject);
			builder.SetPosition(position);
			builder.SetRotation(rotation);
			return builder;
		}
	}
}