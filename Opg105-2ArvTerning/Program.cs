using System;

namespace Opg105_2ArvTerning
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {

            Terning t = new Terning();
            Console.Write("Terning nr : "+i);
            t.Skriv();

            LudoTerning l = new LudoTerning();
            Console.Write("LudoTerning nr: "+i);
            l.Skriv();
            }
        }
    }
}
