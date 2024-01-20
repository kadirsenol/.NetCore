using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace telefonses
{
    public class samsung : basephone
    {
        public override void ses()
        {
           SoundPlayer player = new SoundPlayer();
            player.SoundLocation = $@"../../../samsung.wav";
            player.Play();
            
        }
    }
}
