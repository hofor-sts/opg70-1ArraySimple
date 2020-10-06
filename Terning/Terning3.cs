using System;
using System.Collections.Generic;
using System.Text;

namespace Terning
{
    /// <summary>
    /// Terning med automatisk egenskab
    /// </summary>
    public class Terning3
    {
        public int Værdi { get; private set; }


        // Konstruktør (constructor)
        public Terning3()
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
