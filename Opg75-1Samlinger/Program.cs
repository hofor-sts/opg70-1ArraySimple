using System;
using System.Collections.Generic;

namespace Opg75_1Samlinger
{
    class Program
    {
        static void Main()
        {
            List<int> lst = new List<int>();
            lst.Add(4);
            lst.Add(54);
            lst.Add(94);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Stack<DateTime> sta = new Stack<DateTime>() ;
            sta.Push(new DateTime(2017, 12, 24, 18, 30, 00));
            sta.Push(DateTime.Now);
            sta.Push(new DateTime(2019, 05, 17, 8, 30, 00));
            foreach (var item in sta)
            {
                Console.WriteLine(item);
            }
            DateTime god_dag = sta.Pop();
            Console.WriteLine("Fødselsdag: "+god_dag);

            Dictionary<int, string> Dix = new Dictionary<int, string>();
            Dix.Add(4, "Hillerød");
            Dix.Add(54, "Søborg");
            Dix.Add(94, "Taastrup");

            Console.WriteLine("Husnummer 54 blev brugt i byen "+Dix[54]);
        }
    }
}
