using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome_Carina_Sophia
{
    internal class KochherdStatus : Kueche
    {

        public enum KochherdStatusEnum
        {
            Aus,
            Ein,
            AusAberNochWarm
        }
    }
}
