using System;
using System.Collections.Generic;
using System.Text;

namespace Opg100_3StorArv
{
    class Terning
    {
        private int værdi;

        public int Værdi
        {
            get { return værdi; }
            set {
                værdi = value;
                if (value<1 || value>6)
                {
                    værdi = 1;
                }    
            }
        }

        private static System.Random rnd = new System.Random();

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

    }
}
