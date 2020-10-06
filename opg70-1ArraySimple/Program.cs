using System;

namespace opg70_1ArraySimple
{
    class Program
    {
        static void Main()
        {
            int tot=0;
            double gns;
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            foreach (int item in månedsløn)
            {
                Console.WriteLine(item);
                tot += item;
            }
            gns = tot / månedsløn.Length;
            Console.WriteLine("Gennemsnit "+ gns.ToString("N2"));
            Console.WriteLine();
            Console.WriteLine("Sorteret:");
            System.Array.Sort(månedsløn);
            foreach (int item in månedsløn)
            {
                Console.WriteLine(item);
            }
        }
    }
}
