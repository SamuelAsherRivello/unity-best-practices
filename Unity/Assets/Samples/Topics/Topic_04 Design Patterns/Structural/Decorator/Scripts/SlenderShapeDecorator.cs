
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class SlenderShapeDecorator : ShapeDecorator 
	{
		public SlenderShapeDecorator(IShape shape) : base(shape) { }

		public override void DrawMe()
		{
			Vector3 scale = _shape.Transform.localScale;
			scale.x *= .5f;
			scale.y *= 2;
			scale.z *= .5f;

			_shape.Transform.localScale = scale;
			_shape.DrawMe();
		}
	}
}