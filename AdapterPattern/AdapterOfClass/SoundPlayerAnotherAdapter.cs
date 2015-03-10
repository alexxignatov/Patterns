using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using AdapterPattern.Interface;

namespace AdapterPattern.AdapterOfClass
{
    /// <summary>
    /// Другая реализация паттерна Адаптер.
    /// Наследуем и от интерфейса и от класса, который надо адаптировать
    /// </summary>
    public class SoundPlayerAnotherAdapter : SoundPlayer, IAudioPlayer
    {
        public void Load(string file)
        {
            this.SoundLocation = file;
            this.Load();
        }
    }
}
