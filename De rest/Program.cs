using System;

namespace De_rest
{
    class Program
    {
        static void Main(string[] args)
        {
            //OpdrachtStudent();
            //OpdrachtPizza();
            //OpdrachtRechthoek();
            OpdrachtBankmanager();





        }

        //Opdrachten in aparte methodes voor overzicht
        static void OpdrachtStudent()
        {
            Student student1 = new Student();
            student1.Naam = "Shourov Ahmed";
            student1.Klas = Klassen.EA4;
            student1.Leeftijd = 21;
            student1.PuntenCommunicatie = 15;
            student1.PuntenProgrammingPrinciples = 17;
            student1.PuntenWebTech = 9;

            student1.GeefOverzicht();
        }

        static void OpdrachtPizza()
        {
            Pizza pizza1 = new Pizza();
            pizza1.Diameter = 15;
            pizza1.Toppings = "ananas + kip + extra kaas";
            pizza1.Price = 14.99;

            pizza1.ToonPizza();

            Pizza pizza2 = new Pizza();
            pizza1.Diameter = 0;
            pizza1.Toppings = "";
            pizza1.Price = -1;

            pizza2.ToonPizza();








        }

        static void OpdrachtRechthoek()
        {
            Rechthoek rect1 = new Rechthoek();
            rect1.Lengte = 5;
            rect1.Breedte = 7;

            rect1.ToonOppervlakte();

            Rechthoek rect2 = new Rechthoek();
            rect2.Lengte = -2;
            rect2.Breedte = 7;

            rect2.ToonOppervlakte();

            Rechthoek rect3 = new Rechthoek();
            rect3.Lengte = 5;
            rect3.Breedte = -7;

            rect3.ToonOppervlakte();

            Rechthoek rect4 = new Rechthoek();
            rect4.Lengte = -2;
            rect4.Breedte = -7;

            rect4.ToonOppervlakte();


        }

        static void OpdrachtBankmanager()
        {
            Account rekening1 = new Account();
            Account rekening2 = new Account();

            rekening1.Naam = "Pieter";
            rekening2.Naam = "Koen";

            rekening1.Bedrag = 1000;
            rekening2.Bedrag = 700;
            
            rekening1.GetBalance();
            rekening2.GetBalance();

            rekening1.ChangeState(accountState.Geblokkeerd);

            rekening1.PayInFunds(400);
            rekening2.PayInFunds(300);
            
            rekening1.ChangeState(accountState.Geblokkeerd);

            rekening1.WithdrawFunds();
            rekening2.WithdrawFunds();

            



        }
    }
}
