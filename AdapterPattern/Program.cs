using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdapterPattern.AdapterOfObject;
using AdapterPattern.Interface;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //для 1) случая - адаптер объекта
            IAudioPlayer player = new SoundPlayerAdapter();

            string mp3File = string.Empty;
            PlayMusic(player, mp3File);

            //для 2) случая - адаптер класса
            IAudioPlayer player2 = new AdapterOfClass.SoundPlayerAnotherAdapter();
            string wavFile = string.Empty;
            PlayMusic(player2, wavFile);

            Console.ReadLine();
        }

        private static void PlayMusic(IAudioPlayer player, string file)
        {
            Console.WriteLine(player.ToString());

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
