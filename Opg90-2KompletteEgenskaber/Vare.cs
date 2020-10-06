using System;
using System.Collections.Generic;
using System.Text;

namespace Opg90_2KompletteEgenskaber
{
    class Vare
    {
        private string navn;


        // Konstruktør 
        // default constructor
        public Vare()
        {
            navn = "";
            pris = 0;
        }

        // costum constructor
        public Vare(string n, double p)
        {
            navn = n;
            pris = p;
        }

        public string Navn
        {
            get {
                Console.WriteLine("Aflæser navn til "+navn  );
                return navn; }
            set {
                Console.WriteLine("Sætter navn til "+value);
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Aflæser pris til " + pris);
                return pris; }
            set
            {
                Console.WriteLine("Sætter pris til " + value); 
                pris = value; }
        }

        public double PrisMedMoms()
        {
            return pris*1.25;
        }

        public void Skriv()
        {
            Console.Write("Varen hedder " + navn);
            Console.Write(" og koster " + pris+" kr.");
            Console.WriteLine(" hvilket med moms giver " + this.PrisMedMoms() + " kr.");
        }
    }
}
