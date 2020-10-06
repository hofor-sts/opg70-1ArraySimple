using System;

namespace Opg90_4AutEgenskaber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("lav en ny person");
            Person p;
            p = new Person("Jesper","Larsen");
            Console.WriteLine("Har nu lavet personen "+p.FuldtNavn());
            p.Fornavn = "Hannibal";
            p.Efternavn = "The cannibal";
            Console.WriteLine("Har nu ændret personen til " + p.FuldtNavn());
        }
    }
}
