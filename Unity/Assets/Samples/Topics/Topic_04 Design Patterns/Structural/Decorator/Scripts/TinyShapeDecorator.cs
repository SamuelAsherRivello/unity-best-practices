
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class TinyShapeDecorator : ShapeDecorator
	{
		public TinyShapeDecorator(IShape shape) : base(shape) { }

		public override void DrawMe()
		{
			Vector3 scale = _shape.Transform.localScale;
			scale.x *= 0.25f;
			scale.y *= 0.25f;
			scale.z *= 0.25f;
			_shape.Transform.localScale = scale;

			_shape.DrawMe();
		}
	}
}