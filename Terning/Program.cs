using System;

namespace Terning
{
    class Program
    {
        static void Main()
        {
            TestTerning1();
            TestTerning2();
            TestTerning3();
        }

        private static void TestTerning2()
        {
            Console.WriteLine("Test af Terning2");
            Terning2 t;
            t = new Terning2();
            t.Skriv();
            t.Ryst();
            t.Skriv();
        }

        private static void TestTerning1()
        {
            Console.WriteLine("Test af Terning1");
            Terning1 t;
            t = new Terning1();
            t.Skriv();
            t.Ryst();
            t.Skriv();
        }

        private static void TestTerning3()
        {
            Console.WriteLine("Test af Terning3");
            Terning3 t;
            t = new Terning3();
            t.Skriv();
            t.Ryst();
            t.Skriv();
        }
    }
}
