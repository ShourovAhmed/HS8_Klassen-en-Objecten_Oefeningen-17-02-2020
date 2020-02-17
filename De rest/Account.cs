using System;
using System.Collections.Generic;
using System.Text;

namespace De_rest
{
    enum accountState { Geldig, Geblokkeerd }
    class Account
    {
        private accountState state;
        private string rekeningnr = "niet vrijgegeven";

        public string Rekeningnr
        {
            get { return rekeningnr; }
            set
            {
                if (value != "")
                    rekeningnr = value;
                else
                    Console.WriteLine("Voer een geldig bankrekeningnummer in!");
            }
        }

        private string naam = "incognito";

        public string Naam
        {
            get { return naam; }
            set
            {
                if (value != "")
                    naam = value;
                else
                    Console.WriteLine("Voer een naam in!");
            }
        }

        private int bedrag;

        public int Bedrag
        {
            get { return bedrag; }
            set { bedrag = value; }
        }

        public int WithdrawFunds()
        {
            Console.WriteLine("How much would you like to withdraw?");
            //Console.WriteLine("Hoeveel geld wilt u afhalen?");
            Console.WriteLine($"Huidige balans: {bedrag} ({Naam})");
            int wd = Convert.ToInt32(Console.ReadLine());

            bedrag -= wd;

            if (wd > bedrag)
            {
                bedrag -= bedrag;
                Console.WriteLine("Your funds were too low for this withdrawal, we gave you what we could");
                return bedrag;
                
            }
            else
            {
                Console.WriteLine($"Er werd {wd} euro van uw rekening gehaald.");
                return bedrag;
            }
            Console.WriteLine("\n");

        }

        public void PayInFunds(int donatie)
        {
            bedrag += donatie;
            Console.WriteLine($"Er is {donatie} euro op rekening van {Naam} gestort,");
            Console.WriteLine($"u hebt nu {bedrag} euro op uw rekening staan.");
            Console.WriteLine("\n");
        }

        public void GetBalance()
        {
            Console.WriteLine($"Bankrekeningnummer: {Rekeningnr}");
            Console.WriteLine($"Huidig bedrag op rekening van {Naam}:");
            Console.WriteLine(bedrag);
            Console.WriteLine("\n");
        }

        public void ChangeState(accountState status)
        {
            if (status == accountState.Geblokkeerd)
            {
                Console.WriteLine("ERROR: This account has been blocked");
            }

        }

    }
}
