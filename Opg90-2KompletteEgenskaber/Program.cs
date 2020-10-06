using System;
using System.Runtime.CompilerServices;

namespace Opg90_2KompletteEgenskaber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("lav en ny vare. Sæt derefter navn til The og Pris til 5.50");
            Vare v;
            v = new Vare();
            //v.Skriv();
            v.Navn = "The";
            Console.WriteLine("Varen hedder nu "+v.Navn);
            v.Pris = 5.50;
            Console.WriteLine("Varen koster nu "+v.Pris);
            v.Skriv();
            Console.WriteLine("Lav noget kaffe til 10 kr");
            v = new Vare("Kaffe",10);
            v.Skriv();

        }
    }
}
