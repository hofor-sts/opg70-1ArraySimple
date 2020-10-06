using System;
using System.Collections.Generic;
using System.Text;

namespace Opg100_2RandomPlus
{
    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            int tal = this.Next(1, 1002);
            Console.WriteLine("trak tallet "+tal);
            bool res = tal < 501;
            return res;
        }
    }
}
