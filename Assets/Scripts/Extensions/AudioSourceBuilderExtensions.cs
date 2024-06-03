using UnityEngine;


namespace Refactory.Builders
{
    public static class AudioSourceBuilderExtensions
    {
        /// <summary>
        /// Sets the pitch of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="pitch">The new pitch value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetPitch(this AudioSource audioSource, float pitch)
        {
            audioSource.pitch = pitch;
            return audioSource;
        }

        /// <summary>
        /// Sets the volume of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="volume">The new volume value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetVolume(this AudioSource audioSource, float volume)
        {
            audioSource.volume = volume;
            return audioSource;
        }

        /// <summary>
        /// Sets the loop property of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="loop">Whether the AudioSource should loop.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetLoop(this AudioSource audioSource, bool loop)
        {
            audioSource.loop = loop;
            return audioSource;
        }

        /// <summary>
        /// Sets the mute property of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="mute">Whether the AudioSource should be muted.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetMute(this AudioSource audioSource, bool mute)
        {
            audioSource.mute = mute;
            return audioSource;
        }

        /// <summary>
        /// Sets the AudioClip of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="clip">The new AudioClip.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetClip(this AudioSource audioSource, AudioClip clip)
        {
            audioSource.clip = clip;
            return audioSource;
        }

        /// <summary>
        /// Sets the spatial blend of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="spatialBlend">The new spatial blend value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetSpatialBlend(this AudioSource audioSource, float spatialBlend)
        {
            audioSource.spatialBlend = spatialBlend;
            return audioSource;
        }

        /// <summary>
        /// Sets the doppler level of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="dopplerLevel">The new doppler level value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetDopplerLevel(this AudioSource audioSource, float dopplerLevel)
        {
            audioSource.dopplerLevel = dopplerLevel;
            return audioSource;
        }

        /// <summary>
        /// Sets the spread of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="spread">The new spread value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetSpread(this AudioSource audioSource, float spread)
        {
            audioSource.spread = spread;
            return audioSource;
        }

        /// <summary>
        /// Sets the priority of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="priority">The new priority value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetPriority(this AudioSource audioSource, int priority)
        {
            audioSource.priority = priority;
            return audioSource;
        }

        /// <summary>
        /// Sets the reverb zone mix of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="reverbZoneMix">The new reverb zone mix value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetReverbZoneMix(this AudioSource audioSource, float reverbZoneMix)
        {
            audioSource.reverbZoneMix = reverbZoneMix;
            return audioSource;
        }

        /// <summary>
        /// Sets the minimum distance of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="minDistance">The new minimum distance value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetMinDistance(this AudioSource audioSource, float minDistance)
        {
            audioSource.minDistance = minDistance;
            return audioSource;
        }

        /// <summary>
        /// Sets the maximum distance of the AudioSource.
        /// </summary>
        /// <param name="audioSource">The AudioSource to modify.</param>
        /// <param name="maxDistance">The new maximum distance value.</param>
        /// <returns>The modified AudioSource.</returns>
        public static AudioSource SetMaxDistance(this AudioSource audioSource, float maxDistance)
        {
            audioSource.maxDistance = maxDistance;
            return audioSource;
        }
    }
}