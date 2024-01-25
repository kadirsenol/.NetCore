using Polimorfizm_Phone_Sounds_.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_Phone_Sounds_.Concrete
{
    public class Nokia : BasePhone, IPhone
    {
        public void play()
        {
            player.SoundLocation = $@"C:\Users\kdrsn\source\repos\Visual Studio\MyGithubProject\C#\Polimorfizm(Phone Sounds)\Sounds\nokia.wav";
            player.Play();  
        }
    }
}
