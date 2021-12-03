using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semestralka_windows_forms
{
    class Banka
    {
        public uint ID { get; private set; }
        public DateTime Datum { get; private set; }
        public int Castka { get; private set; }
        public Banka(uint id, DateTime platba, int castka)
        {
            ID = id;
            Datum = platba;
            Castka = castka;
        }
    }
}
