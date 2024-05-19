using UnityEngine;
using UnityEngine.SceneManagement;

namespace RMC.BestPractices.Shared
{
	/// <summary>
	/// Press the Spacebar to restart the scene.
	/// </summary>
	public class RestartSceneController : MonoBehaviour
	{
		protected void Update()
		{
			// Restart Scene		------------------------------------
			if (Input.GetKey(KeyCode.Space))
			{
				Debug.Log("Pressing Spacebar in any Scene, Restarts the Scene");
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
	}
}