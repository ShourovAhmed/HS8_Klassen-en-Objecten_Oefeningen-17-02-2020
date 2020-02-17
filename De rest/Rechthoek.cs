using System;
using System.Collections.Generic;
using System.Text;

namespace De_rest
{
    class Rechthoek
    {
        private int lengte;

        public int Lengte
        {
            get { return lengte; }
            set
            {
                if (value >= 1)
                    lengte = value;
                else
                    Console.WriteLine("De lengte mag niet kleiner dan 1cm zijn");
            }
        }

        private int breedte;

        public int Breedte
        {
            get { return breedte; }
            set
            {
                if (value >= 1) breedte = value;
                else
                    Console.WriteLine("De breedte mag niet kleiner dan 1 cm zijn");
            }
        }


        public void ToonOppervlakte()
        {
            if (Lengte >= 1 && Breedte >= 1)
                Console.WriteLine($"De oppervlakte van deze rechthoek is {Lengte * Breedte}cm²");
            Console.WriteLine("\n");

        }



    }
}
