using System;
using System.Collections.Generic;
using System.Text;

namespace De_rest
{
    class Pizza
    {

        private string toppings;

        public string Toppings
        {
            get { return toppings; }
            set
            {
                if (value != "")
                { toppings = value; }

                else
                { Console.WriteLine("Gelieve toppings toe te voegen"); }
            }
        }

        private int diameter;

        public int Diameter
        {
            get { return diameter; }
            set
            {
                if (value > 0)
                {
                    diameter = value;
                }
                else
                { Console.WriteLine("Error: kan geen pizza met negatieve diameter maken"); }
            }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)

                { price = value; }
                else
                { Console.WriteLine("Error: negatieve prijs"); }
            }
        }

        public void ToonPizza()
        {
            if (Diameter > 0 && Price > 0 && Toppings != "")
            {
                Console.WriteLine("Pizza");
                Console.WriteLine("***");
                Console.WriteLine($"Diameter: {Diameter}cm");
                Console.WriteLine($"Toppings: {Toppings}");
                Console.WriteLine($"Prijs: {Price} euro");
                Console.WriteLine("\n");

            }


        }




    }


}
