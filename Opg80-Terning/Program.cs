using System;

namespace Opg80_1TerningSimpel
{
    class Program
    {
        static void Main()
        {
            Terning t1 = new Terning();
            Console.WriteLine(t1.Værdi);    // 1
            t1.Ryst();
            Console.WriteLine(t1.Værdi);    // tilfældig værdi

            Terning t2 = new Terning(2);
            Console.WriteLine(t2.Værdi);    // 2
            t2.Ryst();
            Console.WriteLine(t2.Værdi);    // tilfældig værdi

            Terning t3 = new Terning(8);    // Fejl: Forkert værdi
            Console.WriteLine(t3.Værdi);
        }
    }

    public class Terning
    {
        // fields
        public int Værdi;

        //Default constructor
        public Terning()
        {
            this.Værdi = 1;
        }

        //custom constructor
        public Terning(int i)
        {
            if (i < 1 || i > 6)
            {
                throw new Exception("Forkert værdi");
            }
            this.Værdi = i;
        
        }

        //metoder
        public void Ryst()
        {
            System.Random rnd = new System.Random();
            int tal = rnd.Next(1, 7);
            this.Værdi = tal;
        }
    }
}
