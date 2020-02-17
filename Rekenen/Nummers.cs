using System;
using System.Collections.Generic;
using System.Text;

namespace Rekenen
{
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public int Som()
        {
            return (Getal1 + Getal2);
        }
        public int Verschil()
        {
            return (Getal1 - Getal2);
        }
        public int Product()
        {
            return (Getal1 * Getal2);
        }
        public string Quotiënt()
        {
            if (Getal2 == 0)
            {
               return "ERROR";
            }
            else
            { return $"{Getal1 / (Getal2 + 0.0)}";}
            
        }
    }
}
