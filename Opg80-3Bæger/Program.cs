using System;
using System.Threading.Channels;

namespace Opg80_3Bæger
{
    class Program
    {
        static void Main()
        {
            Bæger b = new Bæger();
            b.Skriv();
            b.Ryst();
            b.Skriv();
        }
    }
    public class Terning
    {
        // fields
        private static Random rnd = new Random();
        public int værdi;

        //Default constructor
        public Terning()
        {
            this.værdi = 1;
        }

        //metoder
        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }
    }
    public class Bæger
    {
        // fields
        private Terning[] terninger = new Terning[5];

        //Default constructor
        public Bæger()
        {
            for (int i = 0; i < 5; i++)
                terninger[i] = new Terning();
            Ryst();
        }

        //metoder
        public void Skriv()
        {
            foreach (var item in this.terninger)
            {
                item.Skriv();
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        public void Ryst()
        {
            foreach (var item in this.terninger)
            {
                item.Ryst();
            }
        }
    }
}
