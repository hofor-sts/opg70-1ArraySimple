using System;

namespace Opg80_4Person
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Person
    {
        string Fornavn;
        string Efternavn;
        int Fødselsår;

        //Default constructor
        public Person()
        {
            this.Fornavn = "";
            this.Efternavn = "";
            Fødselsår = 0;
        }
        public Person(string forn, string eftern, int år)
        {
            this.Fornavn = forn;
            this.Efternavn = eftern;
            this.Fødselsår = år;
        }

        public void FuldtNavn()
        {
            Console.WriteLine(this.Fornavn+" "+this.Efternavn+" født "+this.Fødselsår);
         }
    }
}
