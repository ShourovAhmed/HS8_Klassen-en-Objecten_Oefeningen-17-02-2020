using System;

namespace Rapport_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Resultaat mijnpunten = new Resultaat();

            //Testen van de randvoorwaarden
            mijnpunten.Percentage = 49;
            mijnpunten.PrintGraad();

            mijnpunten.Percentage = 50;
            mijnpunten.PrintGraad();

            mijnpunten.Percentage = 68;
            mijnpunten.PrintGraad();

            mijnpunten.Percentage = 75;
            mijnpunten.PrintGraad();

            mijnpunten.Percentage = 85;
            mijnpunten.PrintGraad();

        }
    }
}
