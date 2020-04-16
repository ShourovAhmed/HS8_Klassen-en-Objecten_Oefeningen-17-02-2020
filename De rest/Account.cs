using System;
using System.Collections.Generic;
using System.Text;

namespace De_rest
{
    enum accountState { Geldig, Geblokkeerd }
    class Account
    {
        private accountState state = accountState.Geldig;
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

        //METHODEN
        public int WithdrawFunds()
        {
            if (state == accountState.Geblokkeerd)
            {
                Console.WriteLine($"ERROR: This account ({Naam}) has been blocked, you can't withdraw any money from this account!");
                Console.WriteLine("\n");
                return bedrag;
            }
            else
            {
                Console.WriteLine("How much would you like to withdraw?");
                //Console.WriteLine("Hoeveel geld wilt u afhalen?");
                Console.WriteLine($"Current balance: {bedrag} ({Naam})");
                int wd = Convert.ToInt32(Console.ReadLine());

                bedrag -= wd;

                if (wd > bedrag)
                {
                    bedrag -= bedrag;
                    Console.WriteLine("Your funds were too low for this withdrawal, we gave you what we could");
                    Console.WriteLine("\n");
                    return bedrag;

                }
                else
                {
                    Console.WriteLine($"Er werd {wd} euro van uw rekening gehaald.");
                    Console.WriteLine("\n");
                    return bedrag;
                }
            }
        }

        public void PayInFunds(int donatie)
        {
            if (state == accountState.Geblokkeerd)
            {
                Console.WriteLine($"ERROR: This account ({Naam}) has been blocked, you can't deposit any money in this account!");
                Console.WriteLine("\n");
            }

            else
            {
                bedrag += donatie;
                Console.WriteLine($"Er is {donatie} euro op rekening van {Naam} gestort,");
                Console.WriteLine($"U hebt nu {bedrag} euro op uw rekening staan.");
                Console.WriteLine("\n");
            }
        }

        public void GetBalance()
        {
            if (state == accountState.Geblokkeerd)
            {
                Console.WriteLine($"ERROR: This account ({Naam}) has been blocked, you can't see your balance anymore!");
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine($"Bankrekeningnummer: {Rekeningnr}");
                Console.WriteLine($"Huidig bedrag op rekening van {Naam}:");
                Console.WriteLine(bedrag);
                Console.WriteLine("\n");
            }
        }

        public void ChangeState(accountState status)
        {
            if (status == accountState.Geblokkeerd)
            {
                state = accountState.Geblokkeerd;
                Console.WriteLine($"This account, owned by {Naam}, has been blocked now");
            }

        }

    }
}
