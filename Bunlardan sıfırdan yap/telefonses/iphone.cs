using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace telefonses
{
    public class iphone:basephone
    {
        public override void ses()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = $@"../../../iphone.wav";
            player.Play();
        }
        
        
    }
}
