using System;
using System.Collections.Generic;
using System.Text;

namespace Opg105_2ArvTerning
{
    class LudoTerning : Terning
    {
        public bool ErGlobus() {
            if (Værdi==3)
            {
                return true;
            }
            return false;
        }
        public bool ErStjerne()
        {
            if (Værdi == 5)
            {
                return true;
            }
            return false;
        }
        public LudoTerning()
        {
            
        }

        public LudoTerning(int værdi)
        {

        }

        public override void Skriv()
        {
            if (ErGlobus())
            { Console.WriteLine("[G]"); return; }
            if (ErStjerne())
            { Console.WriteLine("[S]"); return; }
            Console.WriteLine("["+Værdi+ "]");
        }
    }
}
