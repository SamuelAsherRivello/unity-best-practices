using System.Collections.Generic;
using UnityEngine;

namespace RMC.BestPractices.DesignPatterns.StructuralPatterns.Decorator
{
	/// <summary>
	/// TODO: Add comment
	/// </summary>
	public class AudioSystem : MonoBehaviour
	{
		[SerializeField]
		private List<AudioClip> _audioClips = new List<AudioClip>();

		[SerializeField]
		private List<AudioSource> _audioSources = new List<AudioSource>();

		/// <summary>
		/// Play the AudioClip by index.
		/// </summary>
		public void PlayAudioClip(int index)
		{
			PlayAudioClip(_audioClips[index]);
		}

		/// <summary>
		/// Play the AudioClip by reference.
		/// If all sources are occupied, nothing will play.
		/// </summary>
		private void PlayAudioClip(AudioClip audioClip)
		{
			foreach (AudioSource audioSource in _audioSources)
			{
				if (!audioSource.isPlaying)
				{
					audioSource.clip = audioClip;
					audioSource.Play();
					return;
				}
			}
		}
	}
}