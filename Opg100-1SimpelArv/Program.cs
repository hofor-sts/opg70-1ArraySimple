using System;

namespace Opg100_1SimpelArv
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("lav en ny person");
            Person p;
            p = new Person("Jesper", "Larsen");
            Console.WriteLine("Har nu lavet personen " + p.FuldtNavn());
            p.Fornavn = "Hannibal";
            p.Efternavn = "The cannibal";
            Console.WriteLine("Har nu ændret personen til " + p.FuldtNavn());

            Console.WriteLine("lav en ny Elev");
            Elev e;
            e = new Elev();
            e.Fornavn = "Steen";
            e.Efternavn = "Schjønning";
            e.Klasselokale = "8.2.9";
            Console.WriteLine("Har nu lavet eleven " + e.FuldtNavn());

            Console.WriteLine("lav en ny Instruktør");
            Instruktør i;
            i = new Instruktør();
            i.Fornavn = "Michell";
            i.Efternavn = "Cronberg";
            i.NøgleId = 829;
            Console.WriteLine("Har nu lavet Instruktøren " + i.FuldtNavn());

        }
    }
}
