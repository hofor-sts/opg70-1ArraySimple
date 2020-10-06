using System;
using System.Collections.Generic;
using System.Text;

namespace Opg90_4AutEgenskaber
{
    class Person
    {
        public String Fornavn { get; set; }

        private String efternavn;
        public String Efternavn
        {
            get { return efternavn; }
            set { efternavn = value; }
        }

        public Person(string f, string e)
        {
            Fornavn = f;
            Efternavn = e;
        }
        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}
