using System;
using System.Collections.Generic;
using System.Text;

namespace Terning
{
    ///
    ///Terning med OFFENTLIGT felt
    /// 
    class Terning1
    {

        //Felter
        public int Værdi;

        // Konstruktør (constructor)
        public Terning1()
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
