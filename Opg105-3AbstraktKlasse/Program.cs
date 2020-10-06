using System;

namespace Opg105_3AbstraktKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursist k = new Kursist() { Id = 1, Navn = "a" };
            k.Skriv1();
            k.Skriv2();

        }
    }
}
