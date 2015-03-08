using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.AdapterOfObject;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAudioPlayer player = new SoundPlayerAdapter();

            string mp3File = string.Empty;
            PlayMusic(player, string.Empty);
            Console.ReadLine();
        }

        private static void PlayMusic(IAudioPlayer player, string file)
        {
            if (!string.IsNullOrEmpty(file))
            {
                player.Load(file);
                player.Play();
                Console.WriteLine("tram pam pam ...");
            }
            else
            {
                Console.WriteLine("no music. silence ...");
            }
        }
    }
}
