using System;
using System.Collections.Generic;
using System.Text;

namespace Opg105_1SimpelPolymorfi
{
    class faktura
    {

        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }

        public override string ToString()
        {
            return "Faktura til "+Kunde+" nr "+Nr+" fra "+Dato;
        //    string jsonString;
        //    jsonString = JsonSerializer.Serialize(this);
        //    return jsonString;
        }
    }
}
