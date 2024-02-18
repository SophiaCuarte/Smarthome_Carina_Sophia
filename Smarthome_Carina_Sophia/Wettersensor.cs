using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smarthome_Carina_Sophia
{
    internal class Wettersensor
    {
        private double aktuelleTemperatur;
        private Random zufaellig;
        public const int MAX_TEMP = 100;
        public const int MIN_TEMP = 100;

        public class WetterDatenService
        {
            public Wetterdaten GetWetterdaten()
            {
                Wetterdaten wetterdaten = new Wetterdaten(); 
                return wetterdaten;
            }
        }

    }
}
