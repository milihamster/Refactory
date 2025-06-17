using UnityEngine;

namespace Refactory.Managers
{
    public class AudioManager : BaseManager<AudioManager>
    {
        private AudioSource _audioSource;

        void Start()
        {
            _audioSource = gameObject.AddComponent<AudioSource>();
        }

        public void PlaySound(AudioClip clip)
        {
            _audioSource.PlayOneShot(clip);
        }
        
        public AudioSource CreateAudioSource(GameObject targetGameObject = null)
        {
            targetGameObject ??= gameObject;
            return targetGameObject.AddComponent<AudioSource>();
        }
    }
}
