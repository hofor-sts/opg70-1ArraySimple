using System;

namespace Opg100_2RandomPlus
{
    class Program
    {
        static void Main()
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool()); // true eller false
        }
    }
}
