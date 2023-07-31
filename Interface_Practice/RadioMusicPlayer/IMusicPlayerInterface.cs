using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioMusicPlayer
{
    public interface IMusicPlayerInterface
    {
        void Switch(bool on);
        void Retune(double frequency);
        void SetVolume(int loudness);
        void PlayNext();
        void PlayPrevious();
    }
}
