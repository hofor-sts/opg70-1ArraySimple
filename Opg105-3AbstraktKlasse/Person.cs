using System;
using System.Collections.Generic;
using System.Text;

namespace Opg105_3AbstraktKlasse
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine("Person med id "+Id+" og navn "+Navn);
        }

        public abstract void Skriv2();
    }

    class Kursist : Person
    {
        public override void Skriv2()
        {
            Console.WriteLine("Kursist med id " + Id + " og navn " + Navn);
        }
    }
}

