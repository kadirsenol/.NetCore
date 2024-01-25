using Polimorfizm_Phone_Sounds_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_Phone_Sounds_.Concrete
{
    public class Samsung : BasePhone, IPhone
    {
        public void play()
        {
            player.SoundLocation = @$"..\..\..\Sounds\samsung.wav";
            player.Play(); 
        }
    }
}
