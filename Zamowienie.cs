using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolos
{
    class Zamowienie
    {
        public DateTime dataRealizacji { get; set; }
        public bool statusZamowienia { get; set; }
        public string identyfikatorZamowienia { get; set; }
        public bool potwierdzenieElektroniczne { get; set; }

        public void wartoscZamowienia()
        {
            Console.WriteLine("Cena Brutto: {0}", PozycjaZamowienia.);
        }

    }
}
