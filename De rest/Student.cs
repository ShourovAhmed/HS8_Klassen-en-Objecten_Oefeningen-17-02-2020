using System;
using System.Collections.Generic;
using System.Text;

namespace De_rest
{
    enum Klassen { EA1, EA2, EA3, EA4, EA5 }
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas { get; set; }//variabele(property) Klas van het type 'Klassen' (klassen is gwn een enum)
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public double BerekenTotaalCijfer()
        {
            double gem = (PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3.0;
            return gem;
        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"Student: {Naam}, {Leeftijd}");
            Console.WriteLine($"Klas: {Klas}");
            Console.WriteLine("\n");

            Console.WriteLine("Cijferrapport:");
            Console.WriteLine("***********");
            Console.WriteLine($"Communicatie:\t\t{PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technology:\t\t{PuntenWebTech}");
            Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer():F1}");
        }




    }
}
