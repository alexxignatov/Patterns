using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern.Interface
{
    /// <summary>
    /// Simple audio player interface
    /// </summary>
    public interface IAudioPlayer
    {
        /// <summary>
        /// Load the audio file
        /// </summary>
        void Load(string file);

        /// <summary>
        /// Plays the audio file.
        /// </summary>
        void Play();
    }
}
