using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm_Phone_Sounds_.Abstract
{
    public abstract class BasePhone
    {
        public string marka { get; set; }
        public string model { get; set; }
        public SoundPlayer player { get; set; } = new SoundPlayer();   
    }
}
