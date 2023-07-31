using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioMusicPlayer
{
     interface IRadioPlayerInterface
    {
        void Switch(bool on);
        void Retune(double frequency);
        void SetVolume(int loudness);
        void ChangeChannel();

    }
}
