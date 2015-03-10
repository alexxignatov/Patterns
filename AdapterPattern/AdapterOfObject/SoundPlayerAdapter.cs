using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using AdapterPattern.Interface;

namespace AdapterPattern.AdapterOfObject
{
    /// <summary>
    /// Adapter for SoundPlayer class
    /// </summary>
    public class SoundPlayerAdapter : IAudioPlayer
    {
        /// <summary>
        /// Adaptee object
        /// </summary>
        private readonly Lazy<SoundPlayer> lazyPlayer = new Lazy<SoundPlayer>();

        /// <summary>
        /// Load the audio file.
        /// </summary>
        public void Load(string file)
        {
            lazyPlayer.Value.SoundLocation = file;
            lazyPlayer.Value.Load();
        }

        /// <summary>
        /// Plays the audio file.
        /// </summary>
        public void Play()
        {
            lazyPlayer.Value.Play();
        }
    }
}
