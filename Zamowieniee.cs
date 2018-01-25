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
            PozycjaZamowienia Zamowienie = new PozycjaZamowienia();
            Console.WriteLine("Cena Brutto: {0}", Zamowienie.obliczBrutto());
            Console.WriteLine("Cena Netto: {0}", Zamowienie.obliczNetto());
        }

    }
}
