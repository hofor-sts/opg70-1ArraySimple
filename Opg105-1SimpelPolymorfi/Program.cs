using System;

namespace Opg105_1SimpelPolymorfi
{
    class Program
    {
        static void Main()
        {
            faktura f = new faktura();
            f.Kunde = "Firma A";
            f.Nr = 1;
            Console.WriteLine(f);
        }
    }
}
