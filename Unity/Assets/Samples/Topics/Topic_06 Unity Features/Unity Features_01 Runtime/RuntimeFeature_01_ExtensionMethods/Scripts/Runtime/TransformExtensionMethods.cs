using UnityEngine;

/// <summary>
/// </summary>
public static class TransformExtensionMethods
{
	public static void ResetPositionXYZ (this Transform transform)
	{
		Vector3 vector3 = transform.position;
		
		vector3.x = 0;
		vector3.y = 0;
		vector3.z = 0;

		transform.position = vector3;
	}
}
