using JetBrains.Annotations;
using Refactory.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Refactory.Controllers
{
    public class AudioController : BaseController<AudioController>
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
        
        public AudioSource CreateAudioSource(GameObject? targetGameObject = null)
        {
            targetGameObject ??= gameObject;
            return targetGameObject.AddComponent<AudioSource>();
        }
    }
}
