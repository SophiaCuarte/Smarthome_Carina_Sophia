using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome_Carina_Sophia
{
    internal class ZimmerDecorator
    {
        protected iZimmer zimmer;
        public string Name;
        public bool PersonenImZimmer;
        public double TemperaturVorgabe;

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {

        }
    }
}
