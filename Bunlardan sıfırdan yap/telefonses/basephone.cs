using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace telefonses
{
    public  class basephone
    {
        SoundPlayer player = new SoundPlayer();
        public string marka { get; set; }
        public string model { get; set; }

        public virtual void ses()
        {
            
            player.SoundLocation = $@"../../../default.wav";
            player.Play();
        }
    }
}
