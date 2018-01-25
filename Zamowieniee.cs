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

        public void wartoscPodatku()
        {
            PozycjaZamowienia Zamowienie = new PozycjaZamowienia();
            Console.WriteLine("Wartość podatku {0}", Zamowienie.obliczBrutto() - Zamowienie.obliczNetto());
        }

        public void oplacZamowienie()
        {
            Platnosc platnosc = new Platnosc();
            Console.WriteLine("Wybierz tryb płatności");
            Console.WriteLine("1) zapłać przelewem");
            Console.WriteLine("2) weź kredyt");
            Console.WriteLine("3) zapłaś gotówką");
            int wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    {
                        platnosc.zaplacPrzelewem();
                        break;
                    }

                case 2:
                    {
                        platnosc.wezKredyt();
                        break;
                    }
                case 3:
                    {
                        platnosc.gotowka();
                        break;
                    }
            }
        }

    }
}
