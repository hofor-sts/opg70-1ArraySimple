using System;
using System.Collections.Generic;
using System.Text;

namespace Terning
{
    /// <summary>
    /// Terning med egenskaber
    /// </summary>
    class Terning2
    {
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set {
                // log
                // Sikkerhed
                if (value < 1 || value > 6)
                    throw new Exception("Forkert værdi");
                værdi = value; }
        }

        // Konstruktør (constructor)
        public Terning2()
        {
            this.Ryst();
        }

        //Metoder
        public void Ryst()
        {
            var tt = new Random();
            this.Værdi = tt.Next(1, 7);
        }

        public void Skriv()
        {
            Console.WriteLine($"[ {this.Værdi} ]");
        }

    }
}
